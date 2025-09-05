using HaftRokh.Properties;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HaftRokh
{

    public partial class Main : Form
    {
        
        static int Year = Core.Persian.GetYear(DateTime.Now);
        static int Month = Core.Persian.GetMonth(DateTime.Now);
        static int Day = Core.Persian.GetDayOfMonth(DateTime.Now);
        string Today = $"{Year:0000}/{Month:00}/{Day:00}";
        JArray Holidays;

        private static ResourceManager resourceMan;
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (resourceMan is null)
                {
                    ResourceManager temp = new ResourceManager("HaftRokh.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

        // White = True - Black = False

        private static readonly System.Globalization.CultureInfo resourceCulture;
        public Main()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
        private readonly RegistryKey Startup = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Holidays = (JArray)Core.Holidays.SelectToken(Year.ToString());
            }
            catch { }
            Hide();

            if (Properties.Settings.Default.FirstTime)
            {
                TrayIcon.BalloonTipTitle = "هفت رخ";
                TrayIcon.BalloonTipText = "اگر ویجت برای شما نمایان نیست، از بخش System Tray آیکون برنامه را به بیرون از لیست بکشید";
                TrayIcon.ShowBalloonTip(3000);

                TrayIcon.BalloonTipTitle = "حالت سازگاری";
                TrayIcon.BalloonTipText = "اگر رنگ ویجت صحیح نیست، با راست کلیک کردن روی آیکون برنامه وارد بخش تنظیمات شده و حالت سازگاری را روشن کنید";
                TrayIcon.ShowBalloonTip(3000);

                Properties.Settings.Default.FirstTime = false;
                Properties.Settings.Default.Save();

                Startup.SetValue("HaftRokh", Application.ExecutablePath);
            }

        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private System.Drawing.Icon GetIcon(bool DarkMode, int DayOfMonth, bool Holiday = false)
        {
            if (Holiday)
            {
                object obj = ResourceManager.GetObject("Red" + DayOfMonth, resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
            else
            {
                if (DarkMode)
                {
                    object obj = ResourceManager.GetObject("Icondark" + DayOfMonth, resourceCulture);
                    return ((System.Drawing.Icon)(obj));
                }
                else
                {
                    object obj = ResourceManager.GetObject("Icon" + DayOfMonth, resourceCulture);
                    return ((System.Drawing.Icon)(obj));
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            TrayIcon.Text = Core.ToPersianDigits(string.Format("{3}، {2} {1} {0}", Year, Core.GetMonthName(Month), Day, Core.GetDayOfWeekName(DateTime.Now)));
            if (Holidays.Any(x => x["date"]?.ToString() == Today))
            {
                try
                {
                    TrayIcon.Icon = GetIcon(!ShouldSystemUseDarkMode(), Day, true);
                }
                catch { }
            }
            else
            {
                if (!Properties.Settings.Default.Compatibility)
                {
                    TrayIcon.Icon = GetIcon(!ShouldSystemUseDarkMode(), Day);
                }
                else
                {
                    TrayIcon.Icon = GetIcon(ShouldSystemUseDarkMode(), Day);
                }
            }

        }
        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("https://time.ir");
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form setting = new Settings();
            setting.ShowDialog();
        }
        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form Calendar = new Calendar();
                if (HaftRokh.Calendar.Displayed == false)
                {
                    Calendar.Show();
                    Calendar.Activate();
                }
                else
                {
                    Calendar.Close();
                    HaftRokh.Calendar.Displayed = false;
                }
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Properties.Settings.Default.DateFormat.Replace("YYYY", Year.ToString()).Replace("MM", Month.ToString()).Replace("DD", Day.ToString()));
        }
    }
}
