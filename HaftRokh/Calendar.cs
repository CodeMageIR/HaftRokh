using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HaftRokh
{
    public partial class Calendar : Form
    {
        PersianCalendar Persian = Core.Persian;
        private DateTime CurrentDate = DateTime.Now;

        public static bool Displayed = false;
        public Calendar()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);

            SetupGrid();
            RenderMonth(CurrentDate);

            CalendarTable.SelectionChanged += (s, e) => CalendarTable.ClearSelection();
        }
        private void SetupGrid()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, CalendarTable, new object[] { true });

            CalendarTable.ColumnHeadersDefaultCellStyle.BackColor = Core.WindowsAccent.GetAccentColor();

            CalendarTable.Columns.Clear();
            for (int i = 0; i < 7; i++)
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn
                {
                    HeaderText = Core.DaysofWeek[i],
                    Name = "col" + i,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    ReadOnly = true,
                    Width = 90
                };
                CalendarTable.Columns.Add(Column);
            }

            CalendarTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RenderMonth(DateTime Date)
        {
            CalendarTable.SuspendLayout();
            CalendarTable.Rows.Clear();

            int Year = Persian.GetYear(Date);
            int Month = Persian.GetMonth(Date);
            int DaysinMonth = Persian.GetDaysInMonth(Year, Month);

            string MonthName = Core.PersianMonthName(Month);
            LabelMonthName.Text = $"{MonthName} {Core.ToPersianDigits(Year.ToString())}";

            DateTime FirstDay = Persian.ToDateTime(Year, Month, 1, 0, 0, 0, 0);
            int StartColumn = ((int)FirstDay.DayOfWeek + 1) % 7;

            int PrevMonth = Month == 1 ? 12 : Month - 1;
            int PrevYear = Month == 1 ? Year - 1 : Year;
            int DaysinPRevMonth = Persian.GetDaysInMonth(PrevYear, PrevMonth);

            int TotalCells = StartColumn + DaysinMonth;
            int TotalRows = (int)Math.Ceiling(TotalCells / 7.0);

            for (int Row = 0; Row < TotalRows; Row++)
                CalendarTable.Rows.Add();

            if (TotalRows == 5)
                Size = new Size(500, 422);
            else if (TotalRows == 6)
                Size = new Size(500, 476);

            int Day = 1;
            int NextMonthDay = 1;

            for (int Row = 0; Row < TotalRows; Row++)
            {
                for (int Column = 0; Column < 7; Column++)
                {
                    DataGridViewCell Cell = CalendarTable.Rows[Row].Cells[Column];
                    Cell.Value = "";
                    Cell.Style.BackColor = Color.FromArgb(243, 243, 243);
                    Cell.Style.ForeColor = Color.FromArgb(40, 40, 40);
                    Cell.Style.Padding = new Padding(0, 4, 0, 4);

                    //alternate row effect
                    /*if (Row % 2 == 1 && Cell.Style.ForeColor != Color.Gray && !IsToday(Year, Month, Day - 1))
                    {
                        Cell.Style.BackColor = Color.FromArgb(230, 230, 230);
                    }*/

                    int CellIndex = Row * 7 + Column;

                    if (CellIndex < StartColumn)
                    {
                        int PrevDays = DaysinPRevMonth - StartColumn + Column + 1;
                        Cell.Value = Core.ToPersianDigits(PrevDays.ToString());
                        Cell.Style.ForeColor = Color.DarkGray;
                        Cell.Style.BackColor = Color.FromArgb(230, 230, 230);
                    }
                    else if (Day <= DaysinMonth)
                    {
                        Cell.Value = Core.ToPersianDigits(Day.ToString());
                        //Cell.Tag = new { Year, Month, Day };

                        try
                        {
                            string Today = $"{Year:0000}/{Month:00}/{Day:00}";
                            JArray ImportantDates = (JArray)Core.ImportantDates.SelectToken(Year.ToString());

                            JToken Events = ImportantDates.FirstOrDefault(x => x["date"]?.ToString() == Today);

                            if (Events != null)
                            {
                                Cell.Style.ForeColor = Core.WindowsAccent.GetAccentColor();

                                List<string> MultipleEvents = ImportantDates.Where(x => x["date"]?.ToString() == Today).Select(x => x["event"]?.ToString()).Where(s => !string.IsNullOrEmpty(s)).ToList();

                                if (MultipleEvents.Count > 1)
                                    Cell.ToolTipText = string.Format("مناسبت ها :{0}", string.Join(" و ", MultipleEvents));
                                else
                                    Cell.ToolTipText = Events["event"]?.ToString() ?? "بدون مناسبت";
                            }
                        }catch{}

                        try
                        {
                            string Today = $"{Year:0000}/{Month:00}/{Day:00}";
                            JArray Holidays = (JArray)Core.Holidays.SelectToken(Year.ToString());

                            if (Holidays.Any(x => x["date"]?.ToString() == Today))
                            {
                                Cell.Style.ForeColor = Color.FromArgb(229, 57, 53);
                                //cell.Style.BackColor = Color.FromArgb(255, 235, 238); 
                            }
                        }catch{}

                        if (Column == 6)
                        {
                            Cell.Style.ForeColor = Color.FromArgb(229, 57, 53);
                            //cell.Style.BackColor = Color.FromArgb(255, 235, 238);
                        }

                        if (IsToday(Year, Month, Day))
                        {
                            if (Cell.Style.ForeColor == Color.FromArgb(229, 57, 53))
                                Cell.Style.BackColor = Color.FromArgb(229, 57, 53);
                            else
                                Cell.Style.BackColor = Core.WindowsAccent.GetAccentColor();

                            Cell.Style.ForeColor = Color.White;
                            Cell.Style.SelectionBackColor = Cell.Style.BackColor;
                            Cell.Style.SelectionForeColor = Cell.Style.ForeColor;

                            ShowEvent(Year, Month, Day, true);
                        }

                        Day++;
                    }

                    else
                    {
                        Cell.Value = Core.ToPersianDigits(NextMonthDay.ToString());
                        Cell.Style.ForeColor = Color.DarkGray;
                        Cell.Style.BackColor = Color.FromArgb(230, 230, 230);
                        NextMonthDay++;
                    }
                }
            }

            CalendarTable.ClearSelection();
            CalendarTable.ResumeLayout();
        }
        private void DgvCalendar_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = CalendarTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Style.ForeColor != Color.DarkGray && !IsToday(Persian.GetYear(CurrentDate), Persian.GetMonth(CurrentDate), ConvertToInt(cell.Value)))
                {
                    cell.Style.BackColor = Color.FromArgb(200, 230, 255);
                }
            }
        }
        private void DgvCalendar_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell Cell = CalendarTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int Day = ConvertToInt(Cell.Value);

                if (Day <= 0)
                {
                    return;
                }

                if (Cell.Style.ForeColor != Color.DarkGray && !IsToday(Persian.GetYear(CurrentDate), Persian.GetMonth(CurrentDate), ConvertToInt(Cell.Value)))
                {
                    int rowIndex = e.RowIndex;
                    //alternate row effect
                    //Cell.Style.BackColor = (rowIndex % 2 == 1) ? Color.FromArgb(230, 230, 230) : Color.FromArgb(243, 243, 243);
                    Cell.Style.BackColor = Color.FromArgb(243, 243, 243);
                }
            }
        }
        private int ConvertToInt(object Value)
        {
            if (Value == null)
            {
                return 0;
            }

            string s = Value.ToString().Replace("۰", "0").Replace("۱", "1").Replace("۲", "2")
                                     .Replace("۳", "3").Replace("۴", "4").Replace("۵", "5")
                                     .Replace("۶", "6").Replace("۷", "7").Replace("۸", "8")
                                     .Replace("۹", "9");
            if (int.TryParse(s, out int Result))
            {
                return Result;
            }

            return 0;
        }
        private bool IsToday(int py, int pm, int pd)
        {
            DateTime now = DateTime.Now;
            return Persian.GetYear(now) == py &&
                   Persian.GetMonth(now) == pm &&
                   Persian.GetDayOfMonth(now) == pd;
        }
        private void BottonPrevMonth_Click(object sender, EventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(-1);
            RenderMonth(CurrentDate);
        }
        private void BottonNextMonth_Click(object sender, EventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(1);
            RenderMonth(CurrentDate);
        }
        private void FrmCalendar_Resize(object sender, EventArgs e)
        {
            CalendarTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Reposition();
        }
        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            Displayed = true;
            Reposition();
        }
        private void FrmCalendar_Leave(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmCalendar_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Displayed = false;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;
            const int WM_SETTINGCHANGE = 0x001A;
            base.WndProc(ref m);

            if (m.Msg == WM_DWMCOLORIZATIONCOLORCHANGED || m.Msg == WM_SETTINGCHANGE)
            {
                Color Accent = Core.WindowsAccent.GetAccentColor();
                ApplyAccent(Accent);
            }
        }
        private void ApplyAccent(Color Accent)
        {
            BackColor = Accent; 
            RenderMonth(CurrentDate);
        }
        private void Calendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewCell Cell = CalendarTable.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (Cell.Style.ForeColor == Color.DarkGray)
            {
                LabelEvent.Text = "";
                return;
            }

            int Year = Persian.GetYear(CurrentDate);
            int Month = Persian.GetMonth(CurrentDate);
            int Day = ConvertToInt(Cell.Value);

            ShowEvent(Year, Month, Day, false);
        }
        private void ShowEvent(int Year, int Month, int Day, bool isToday)
        {
            string Today = $"{Year:0000}/{Month:00}/{Day:00}";

            try
            {
                try
                {
                    JArray Holidays = (JArray)Core.Holidays.SelectToken(Year.ToString());

                    if (Holidays.Any(x => x["date"]?.ToString() == Today))
                    {
                        LabelEvent.ForeColor = Color.FromArgb(229, 57, 53);
                        //cell.Style.BackColor = Color.FromArgb(255, 235, 238); 
                    }
                    else
                        LabelEvent.ForeColor = Color.FromArgb(0, 0, 0);
                }catch{}

                JArray ImportantDates = (JArray)Core.ImportantDates.SelectToken(Year.ToString());
                JToken Events = ImportantDates.FirstOrDefault(x => x["date"]?.ToString() == Today);

                List<string> MultipleEvents = ImportantDates.Where(x => x["date"]?.ToString() == Today).Select(x => x["event"]?.ToString()).Where(s => !string.IsNullOrEmpty(s)).ToList();

                if (MultipleEvents.Count > 1)
                {
                    LabelEvent.Text = string.Format("مناسبت ها :{0}", string.Join(" و ", MultipleEvents));
                }
                else
                {
                    if (Events != null)
                    {
                        if (isToday)
                            LabelEvent.Text = string.Format("مناسبت: {0}", Events["event"]);
                        else
                            LabelEvent.Text = string.Format("{0} {1}: {2}", Day, Core.PersianMonthName(Month), Events["event"]);
                    }
                    else
                    {
                        LabelEvent.Text = "بدون مناسبت";
                        LabelEvent.ForeColor = Color.FromArgb(0, 0, 0);
                    }
                }
            }
            catch
            {
                LabelEvent.Text = "خطا";
                LabelEvent.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
        private void Reposition()
        {
            StartPosition = FormStartPosition.Manual;

            Rectangle ScreenDimension = Screen.PrimaryScreen.WorkingArea;

            Location = new Point(ScreenDimension.Right - Width - 10, ScreenDimension.Bottom - Height - 58);
        }
        private void CalendarTable_Paint(object sender, PaintEventArgs e)
        {
            int headerHeight = CalendarTable.ColumnHeadersHeight;

            using (Pen p = new Pen(Color.White, 2))
            {
                e.Graphics.DrawLine(
                    p,
                    new Point(0, headerHeight - 1),
                    new Point(CalendarTable.Width, headerHeight - 1)
                );
            }
        }
        private void CalendarTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            /*
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var cell = CalendarTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Tag == null)
                return;

            dynamic info = cell.Tag;
            int py = info.Year;
            int pm = info.Month;
            int pd = info.Day;

            DateTime dt = Persian.ToDateTime(py, pm, pd, 0, 0, 0, 0);
            string persianText = Core.ToPersianDigits(pd.ToString());
            string gregorianText = dt.Day.ToString();

            e.PaintBackground(e.CellBounds, true);

            using (var bigFont = new Font("Vazirmatn", 14, FontStyle.Bold))
            using (var smallFont = new Font("Vazirmatn", 7))
            {
                var rectPersian = new Rectangle(e.CellBounds.Left + 2, e.CellBounds.Top + 8, e.CellBounds.Width, 20);

                var rectGregorian = new Rectangle(e.CellBounds.Left + 4, e.CellBounds.Bottom - 18, e.CellBounds.Width - 8, 12);


                TextRenderer.DrawText(e.Graphics, persianText, bigFont, rectPersian, cell.Style.ForeColor, TextFormatFlags.Left);
                TextRenderer.DrawText(e.Graphics, gregorianText, smallFont, rectGregorian, Color.Gray, TextFormatFlags.Left);
            }

            e.Handled = true;*/
        }

    }
}