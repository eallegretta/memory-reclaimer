using Eaa.ChromeCleaner.Properties;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Eaa.ChromeCleaner
{
    internal class ChromeCleanerContext : ApplicationContext
    {
        private readonly Tuple<string, int>[] _intervals = new[]
        {
            new Tuple<string, int>("5 Minutes", 1000 * 60 * 5),
            new Tuple<string, int>("10 Minutes", 1000 * 60 * 10),
            new Tuple<string, int>("15 Minutes", 1000 * 60 * 15),
            new Tuple<string, int>("30 Minutes", 1000 * 60 * 30),
            new Tuple<string, int>("1 Hour", 1000 * 60 * 60),
            new Tuple<string, int>("3 Hours", 1000 * 60 * 60 * 3),
            new Tuple<string, int>("6 Hours", 1000 * 60 * 60 * 6),
            new Tuple<string, int>("12 Hours", 1000 * 60 * 60 * 12),
            new Tuple<string, int>("1 Day", 1000 * 60 * 60 * 24),
        };

        private MenuItem[] _intervalMenuItems = null;

        private int _currentInteval;
        private readonly NotifyIcon _trayIcon;
        private System.Threading.Timer _timer;

        public ChromeCleanerContext()
        {
            SetTimer();

            // Initialize Tray Icon
            _intervalMenuItems = _intervals.Select(x => new MenuItem(x.Item1, (sender, args) => OnIntervalChanged(x.Item2))).ToArray();

            _trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new MenuItem[] 
                {
                    new MenuItem("Clean Interval", _intervalMenuItems),
                    new MenuItem("Exit", OnExit)
                }),
                Visible = true
            };

            _intervalMenuItems[0].Checked = true;
            _currentInteval = _intervals[0].Item2;
        }

        private void CleanChromeInstances()
        {
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                try
                {
                    Win32.EmptyWorkingSet(process.Handle);
                }
                catch
                {

                }
            }

            SetTimer();
        }

        private void OnIntervalChanged(int newInterval)
        {
            _currentInteval = newInterval;

            for (var index = 0; index < _intervals.Length; index++)
            {
                if (_intervals[index].Item2 == newInterval)
                {
                    _intervalMenuItems[index].Checked = true;
                }
                else
                {
                    _intervalMenuItems[index].Checked = false;
                }
            }

            SetTimer();
        }

        private void SetTimer()
        {
            _timer = new System.Threading.Timer(state => CleanChromeInstances(), null, _currentInteval, Timeout.Infinite);
        }

        private void OnExit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            _trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
