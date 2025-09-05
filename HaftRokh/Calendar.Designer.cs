namespace HaftRokh
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.CalendarTable = new System.Windows.Forms.DataGridView();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelEvent = new System.Windows.Forms.Label();
            this.BottonNextMonth = new System.Windows.Forms.PictureBox();
            this.LabelMonthName = new System.Windows.Forms.Label();
            this.BottonPrevMonth = new System.Windows.Forms.PictureBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarTable)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottonNextMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottonPrevMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarTable
            // 
            this.CalendarTable.AllowUserToAddRows = false;
            this.CalendarTable.AllowUserToDeleteRows = false;
            this.CalendarTable.AllowUserToResizeColumns = false;
            this.CalendarTable.AllowUserToResizeRows = false;
            this.CalendarTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CalendarTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalendarTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CalendarTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Vazirmatn", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalendarTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CalendarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Vazirmatn", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CalendarTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.CalendarTable.EnableHeadersVisualStyles = false;
            this.CalendarTable.GridColor = System.Drawing.Color.White;
            this.CalendarTable.Location = new System.Drawing.Point(10, 54);
            this.CalendarTable.MultiSelect = false;
            this.CalendarTable.Name = "CalendarTable";
            this.CalendarTable.ReadOnly = true;
            this.CalendarTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalendarTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Vazirmatn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalendarTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CalendarTable.RowHeadersVisible = false;
            this.CalendarTable.RowTemplate.DividerHeight = 2;
            this.CalendarTable.RowTemplate.Height = 54;
            this.CalendarTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CalendarTable.Size = new System.Drawing.Size(470, 366);
            this.CalendarTable.TabIndex = 0;
            this.CalendarTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Calendar_CellClick);
            this.CalendarTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCalendar_CellMouseEnter);
            this.CalendarTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCalendar_CellMouseLeave);
            this.CalendarTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CalendarTable_CellPainting);
            this.CalendarTable.Paint += new System.Windows.Forms.PaintEventHandler(this.CalendarTable_Paint);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BackgroundColor = System.Drawing.Color.White;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 25;
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.LabelEvent);
            this.Panel.Controls.Add(this.CalendarTable);
            this.Panel.Controls.Add(this.BottonNextMonth);
            this.Panel.Controls.Add(this.LabelMonthName);
            this.Panel.Controls.Add(this.BottonPrevMonth);
            this.Panel.Location = new System.Drawing.Point(5, 5);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(490, 466);
            this.Panel.TabIndex = 4;
            // 
            // LabelEvent
            // 
            this.LabelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEvent.AutoEllipsis = true;
            this.LabelEvent.BackColor = System.Drawing.Color.Transparent;
            this.LabelEvent.Font = new System.Drawing.Font("Vazirmatn", 12F);
            this.LabelEvent.Location = new System.Drawing.Point(10, 426);
            this.LabelEvent.Name = "LabelEvent";
            this.LabelEvent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelEvent.Size = new System.Drawing.Size(470, 32);
            this.LabelEvent.TabIndex = 6;
            this.LabelEvent.Text = "Event";
            this.LabelEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BottonNextMonth
            // 
            this.BottonNextMonth.BackColor = System.Drawing.Color.White;
            this.BottonNextMonth.Cursor = System.Windows.Forms.Cursors.Default;
            this.BottonNextMonth.Image = global::HaftRokh.Properties.Resources.caret_left;
            this.BottonNextMonth.Location = new System.Drawing.Point(10, 8);
            this.BottonNextMonth.Name = "BottonNextMonth";
            this.BottonNextMonth.Size = new System.Drawing.Size(20, 40);
            this.BottonNextMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BottonNextMonth.TabIndex = 7;
            this.BottonNextMonth.TabStop = false;
            this.BottonNextMonth.Click += new System.EventHandler(this.BottonNextMonth_Click);
            // 
            // LabelMonthName
            // 
            this.LabelMonthName.BackColor = System.Drawing.Color.Transparent;
            this.LabelMonthName.Font = new System.Drawing.Font("Vazirmatn", 15F);
            this.LabelMonthName.Location = new System.Drawing.Point(36, 11);
            this.LabelMonthName.Name = "LabelMonthName";
            this.LabelMonthName.Size = new System.Drawing.Size(418, 36);
            this.LabelMonthName.TabIndex = 5;
            this.LabelMonthName.Text = "MonthName";
            this.LabelMonthName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BottonPrevMonth
            // 
            this.BottonPrevMonth.BackColor = System.Drawing.Color.White;
            this.BottonPrevMonth.Cursor = System.Windows.Forms.Cursors.Default;
            this.BottonPrevMonth.Image = global::HaftRokh.Properties.Resources.caret_right__3_;
            this.BottonPrevMonth.Location = new System.Drawing.Point(460, 8);
            this.BottonPrevMonth.Name = "BottonPrevMonth";
            this.BottonPrevMonth.Size = new System.Drawing.Size(20, 40);
            this.BottonPrevMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BottonPrevMonth.TabIndex = 6;
            this.BottonPrevMonth.TabStop = false;
            this.BottonPrevMonth.Click += new System.EventHandler(this.BottonPrevMonth_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Date";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 476);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmCalendar";
            this.Deactivate += new System.EventHandler(this.FrmCalendar_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalendar_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalendar_Load);
            this.Leave += new System.EventHandler(this.FrmCalendar_Leave);
            this.Resize += new System.EventHandler(this.FrmCalendar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarTable)).EndInit();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottonNextMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottonPrevMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CalendarTable;
        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private System.Windows.Forms.PictureBox BottonPrevMonth;
        private System.Windows.Forms.PictureBox BottonNextMonth;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Label LabelEvent;
        private System.Windows.Forms.Label LabelMonthName;
    }
}