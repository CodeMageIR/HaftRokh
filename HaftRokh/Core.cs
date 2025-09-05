using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace HaftRokh
{
    public class Core
    {
        public static JToken Holidays;

        public static JToken ImportantDates;

        public static string[] DaysofWeek = { "ش", "ی", "د", "س", "چ", "پ", "ج" };

        public static readonly System.Globalization.PersianCalendar Persian = new System.Globalization.PersianCalendar();

        public static string GetDayOfWeekName(DateTime date)
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
        public static string GetMonthName(int Month)
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
        private static string HolidaysFile = Path.Combine(Application.StartupPath, "Holidays.json");

        private const string HolidaysUrl = "https://raw.githubusercontent.com/CodeMageIR/HaftRokh/refs/heads/main/Assets/Holidays.json";
        public static bool LoadHolidays()
        {
            try
            {
                if (!File.Exists(HolidaysFile))
                {
                    if (!DownloadHolidays())
                    {
                        MessageBox.Show("خطا در دانلود فایل تعطیلات!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                Holidays = JToken.Parse(File.ReadAllText(HolidaysFile));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگذاری تعطیلات:\n{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DownloadHolidays()
        {
            
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "Other");
                    string jsonString = client.DownloadString(HolidaysUrl);

                    File.WriteAllText(HolidaysFile, jsonString);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در دانلود فایل تعطیلات:\n{ex.Message}", "خطای اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static readonly string ImportantDatesJson = Path.Combine(Application.StartupPath, "ImportantDates.json");
        private const string ImportantDatesUrl = "https://raw.githubusercontent.com/CodeMageIR/HaftRokh/refs/heads/main/Assets/ImportantDates.json";
        public static bool LoadImportantDates()
        {
            try
            {
                if (!File.Exists(ImportantDatesJson))
                {
                    if (!DownloadImportantDates())
                    {
                        MessageBox.Show("خطا در دانلود فایل تاریخ‌های مهم!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                ImportantDates = JToken.Parse(File.ReadAllText(ImportantDatesJson, Encoding.UTF8));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگذاری تاریخ‌های مهم:\n{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool ForceUpdate()
        {
            try
            {
                if (DownloadHolidays() && DownloadImportantDates())
                {
                    return true;
                }
                else 
                    return false;

            }
            catch
            {
                return false;
            }
        }
        public static bool DownloadImportantDates()
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "Other");
                    client.Encoding = Encoding.UTF8;

                    string jsonString = client.DownloadString(ImportantDatesUrl);
                    File.WriteAllText(ImportantDatesJson, jsonString, Encoding.UTF8);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در دانلود فایل تاریخ‌های مهم:\n{ex.Message}", "خطای شبکه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string ToPersianDigits(string input)
        {
            char[] map = { '۰', '۱', '۲', '۳', '۴', '۵', '۶', '۷', '۸', '۹' };
            var chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= '0' && chars[i] <= '9')
                    chars[i] = map[chars[i] - '0'];
            }
            return new string(chars);
        }

        public static string PersianMonthName(int m)
        {
            string[] names = {
                "فروردین","اردیبهشت","خرداد","تیر","مرداد","شهریور",
                "مهر","آبان","آذر","دی","بهمن","اسفند"
            };
            return (m >= 1 && m <= 12) ? names[m - 1] : m.ToString();
        }

        public static class WindowsAccent
        {
            private static Color? FromRegistry()
            {
                var v = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "AccentColor", null) ?? Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null);

                if (v is int i)
                {
                    uint abgr = unchecked((uint)i); 
                    return FromAbgrDword(abgr);
                }
                return null;
            }

            private static Color? FromDwm()
            {
                if (DwmGetColorizationColor(out uint argb, out bool _) == 0)
                {
                    byte a = (byte)((argb >> 24) & 0xFF);
                    byte r = (byte)((argb >> 16) & 0xFF);
                    byte g = (byte)((argb >> 8) & 0xFF);
                    byte b = (byte)(argb & 0xFF);
                    if (a == 0) a = 255; 
                    return Color.FromArgb(a, r, g, b);
                }
                return null;
            }

            private static Color FromAbgrDword(uint abgr)
            {
                byte a = (byte)((abgr >> 24) & 0xFF);
                byte b = (byte)((abgr >> 16) & 0xFF);
                byte g = (byte)((abgr >> 8) & 0xFF);
                byte r = (byte)(abgr & 0xFF);
                if (a == 0) a = 255; 
                return Color.FromArgb(a, r, g, b);
            }

            [DllImport("dwmapi.dll", PreserveSig = true)]
            private static extern int DwmGetColorizationColor(out uint pcrColorization, out bool pfOpaqueBlend);

            public static Color GetAccentColor()
            {
                return FromRegistry() ?? FromDwm() ?? SystemColors.Highlight;
            }
        }

        public class DropShadow
        {
            #region Shadowing

            #region Fields

            private bool _isAeroEnabled = false;
            private bool _isDraggingEnabled = false;
            private const int WM_NCHITTEST = 0x84;
            private const int WS_MINIMIZEBOX = 0x20000;
            private const int HTCLIENT = 0x1;
            private const int HTCAPTION = 0x2;
            private const int CS_DBLCLKS = 0x8;
            private const int CS_DROPSHADOW = 0x00020000;
            private const int WM_NCPAINT = 0x0085;
            private const int WM_ACTIVATEAPP = 0x001C;

            #endregion

            #region Structures

            [EditorBrowsable(EditorBrowsableState.Never)]
            public struct MARGINS
            {
                public int leftWidth;
                public int rightWidth;
                public int topHeight;
                public int bottomHeight;
            }

            #endregion

            #region Methods

            #region Public

            [DllImport("dwmapi.dll")]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

            [DllImport("dwmapi.dll")]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

            [DllImport("dwmapi.dll")]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public static bool IsCompositionEnabled()
            {
                if (Environment.OSVersion.Version.Major < 6) return false;

                bool enabled;
                DwmIsCompositionEnabled(out enabled);

                return enabled;
            }

            #endregion

            #region Private

            [DllImport("dwmapi.dll")]
            private static extern int DwmIsCompositionEnabled(out bool enabled);

            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
             );

            private bool CheckIfAeroIsEnabled()
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    int enabled = 0;
                    DwmIsCompositionEnabled(ref enabled);

                    return (enabled == 1) ? true : false;
                }
                return false;
            }

            #endregion

            #region Overrides

            public void ApplyShadows(Form form)
            {
                var v = 2;

                DwmSetWindowAttribute(form.Handle, 2, ref v, 4);

                MARGINS margins = new MARGINS()
                {
                    bottomHeight = 1,
                    leftWidth = 0,
                    rightWidth = 0,
                    topHeight = 0
                };

                DwmExtendFrameIntoClientArea(form.Handle, ref margins);
            }

            #endregion

            #endregion

            #endregion
        }
    }
}
