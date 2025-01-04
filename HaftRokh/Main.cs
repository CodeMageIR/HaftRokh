using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HaftRokh.Properties;

namespace HaftRokh
{

    public partial class Main : Form
    {
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
        private string GetDayOfWeekName(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Saturday: return "شنبه";
                case DayOfWeek.Sunday: return "يکشنبه";
                case DayOfWeek.Monday: return "دوشنبه";
                case DayOfWeek.Tuesday: return "سه‏ شنبه";
                case DayOfWeek.Wednesday: return "چهارشنبه";
                case DayOfWeek.Thursday: return "پنجشنبه";
                case DayOfWeek.Friday: return "جمعه";
                default: return "";
            }
        }
        private string GetMonthName(int Month)
        {
            switch (Month)
            {
                case 1: return "فروردین";
                case 2: return "اردیبهشت";
                case 3: return "خرداد";
                case 4: return "تیر";
                case 5: return "مرداد";
                case 6: return "شهریور";
                case 7: return "مهر";
                case 8: return "آبان";
                case 9: return "آذر";
                case 10: return "دی";
                case 11: return "بهمن";
                case 12: return "اسفند";
                default: return "";
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Hide();

            if(Properties.Settings.Default.FirstTime)
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
        private System.Drawing.Icon GetIcon(bool DarkMode, int DayOfMonth)
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
        private void Timer_Tick(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar PersianDate = new System.Globalization.PersianCalendar();
            TrayIcon.Text = string.Format("{3}، {2} {1} {0}", PersianDate.GetYear(DateTime.Now), GetMonthName(PersianDate.GetMonth(DateTime.Now)), PersianDate.GetDayOfMonth(DateTime.Now), GetDayOfWeekName(DateTime.Now));
            if(!Properties.Settings.Default.Compatibility)
            {
                TrayIcon.Icon = GetIcon(!ShouldSystemUseDarkMode(), PersianDate.GetDayOfMonth(DateTime.Now));
            }
            else
            {
                TrayIcon.Icon = GetIcon(ShouldSystemUseDarkMode(), PersianDate.GetDayOfMonth(DateTime.Now));
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
    }
}
