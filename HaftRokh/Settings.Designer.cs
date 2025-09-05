namespace HaftRokh
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            this.Topbar = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelName = new System.Windows.Forms.Label();
            this.Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonForceUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DropdownDateFormat = new Bunifu.UI.WinForms.BunifuDropdown();
            this.LabelDateFormat = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.Notice = new System.Windows.Forms.Label();
            this.ToggleCompatibility = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.LabelCompatibility = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Topbar.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.BackgroundColor = System.Drawing.Color.White;
            this.Topbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Topbar.BackgroundImage")));
            this.Topbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Topbar.BorderColor = System.Drawing.Color.Transparent;
            this.Topbar.BorderRadius = 3;
            this.Topbar.BorderThickness = 1;
            this.Topbar.Controls.Add(this.LabelName);
            this.Topbar.Controls.Add(this.Exit);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Topbar.Name = "Topbar";
            this.Topbar.ShowBorders = true;
            this.Topbar.Size = new System.Drawing.Size(513, 33);
            this.Topbar.TabIndex = 1;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(9, 6);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(62, 25);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Setting";
            this.LabelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            // 
            // Exit
            // 
            this.Exit.AllowAnimations = true;
            this.Exit.AllowMouseEffects = true;
            this.Exit.AllowToggling = false;
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AnimationSpeed = 200;
            this.Exit.AutoGenerateColors = false;
            this.Exit.AutoRoundBorders = false;
            this.Exit.AutoSizeLeftIcon = true;
            this.Exit.AutoSizeRightIcon = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.ButtonText = "";
            this.Exit.ButtonTextMarginLeft = 0;
            this.Exit.ColorContrastOnClick = 45;
            this.Exit.ColorContrastOnHover = 45;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Exit.CustomizableEdges = borderEdges1;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.Exit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.Exit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.Exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Exit.IconMarginLeft = 11;
            this.Exit.IconPadding = 10;
            this.Exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Exit.IconSize = 25;
            this.Exit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.IdleBorderRadius = 15;
            this.Exit.IdleBorderThickness = 1;
            this.Exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.IdleIconLeftImage = null;
            this.Exit.IdleIconRightImage = null;
            this.Exit.IndicateFocus = false;
            this.Exit.Location = new System.Drawing.Point(485, 9);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit.Name = "Exit";
            this.Exit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.Exit.OnDisabledState.BorderRadius = 15;
            this.Exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.OnDisabledState.BorderThickness = 1;
            this.Exit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.Exit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.Exit.OnDisabledState.IconLeftImage = null;
            this.Exit.OnDisabledState.IconRightImage = null;
            this.Exit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Exit.onHoverState.BorderRadius = 15;
            this.Exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.onHoverState.BorderThickness = 1;
            this.Exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Exit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Exit.onHoverState.IconLeftImage = null;
            this.Exit.onHoverState.IconRightImage = null;
            this.Exit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.OnIdleState.BorderRadius = 15;
            this.Exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.OnIdleState.BorderThickness = 1;
            this.Exit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Exit.OnIdleState.IconLeftImage = null;
            this.Exit.OnIdleState.IconRightImage = null;
            this.Exit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.OnPressedState.BorderRadius = 15;
            this.Exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.OnPressedState.BorderThickness = 1;
            this.Exit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Exit.OnPressedState.IconLeftImage = null;
            this.Exit.OnPressedState.IconRightImage = null;
            this.Exit.Size = new System.Drawing.Size(15, 15);
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit.TextMarginLeft = 0;
            this.Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Exit.UseDefaultRadiusAndThickness = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.White;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 25;
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.ButtonForceUpdate);
            this.Panel.Controls.Add(this.DropdownDateFormat);
            this.Panel.Controls.Add(this.LabelDateFormat);
            this.Panel.Controls.Add(this.bunifuSeparator1);
            this.Panel.Controls.Add(this.Notice);
            this.Panel.Controls.Add(this.ToggleCompatibility);
            this.Panel.Controls.Add(this.LabelCompatibility);
            this.Panel.Controls.Add(this.Title);
            this.Panel.Location = new System.Drawing.Point(14, 42);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(476, 172);
            this.Panel.TabIndex = 4;
            // 
            // ButtonForceUpdate
            // 
            this.ButtonForceUpdate.AllowAnimations = true;
            this.ButtonForceUpdate.AllowMouseEffects = true;
            this.ButtonForceUpdate.AllowToggling = false;
            this.ButtonForceUpdate.AnimationSpeed = 200;
            this.ButtonForceUpdate.AutoGenerateColors = false;
            this.ButtonForceUpdate.AutoRoundBorders = false;
            this.ButtonForceUpdate.AutoSizeLeftIcon = true;
            this.ButtonForceUpdate.AutoSizeRightIcon = true;
            this.ButtonForceUpdate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonForceUpdate.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonForceUpdate.BackgroundImage")));
            this.ButtonForceUpdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonForceUpdate.ButtonText = "به روز رسانی مناسبت‌ ها";
            this.ButtonForceUpdate.ButtonTextMarginLeft = 0;
            this.ButtonForceUpdate.ColorContrastOnClick = 45;
            this.ButtonForceUpdate.ColorContrastOnHover = 45;
            this.ButtonForceUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ButtonForceUpdate.CustomizableEdges = borderEdges2;
            this.ButtonForceUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonForceUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonForceUpdate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonForceUpdate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonForceUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonForceUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonForceUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonForceUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonForceUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonForceUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonForceUpdate.IconMarginLeft = 11;
            this.ButtonForceUpdate.IconPadding = 10;
            this.ButtonForceUpdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonForceUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonForceUpdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonForceUpdate.IconSize = 25;
            this.ButtonForceUpdate.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.IdleBorderRadius = 1;
            this.ButtonForceUpdate.IdleBorderThickness = 1;
            this.ButtonForceUpdate.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.IdleIconLeftImage = null;
            this.ButtonForceUpdate.IdleIconRightImage = null;
            this.ButtonForceUpdate.IndicateFocus = false;
            this.ButtonForceUpdate.Location = new System.Drawing.Point(18, 129);
            this.ButtonForceUpdate.Name = "ButtonForceUpdate";
            this.ButtonForceUpdate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonForceUpdate.OnDisabledState.BorderRadius = 1;
            this.ButtonForceUpdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonForceUpdate.OnDisabledState.BorderThickness = 1;
            this.ButtonForceUpdate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonForceUpdate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonForceUpdate.OnDisabledState.IconLeftImage = null;
            this.ButtonForceUpdate.OnDisabledState.IconRightImage = null;
            this.ButtonForceUpdate.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.onHoverState.BorderRadius = 1;
            this.ButtonForceUpdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonForceUpdate.onHoverState.BorderThickness = 1;
            this.ButtonForceUpdate.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonForceUpdate.onHoverState.IconLeftImage = null;
            this.ButtonForceUpdate.onHoverState.IconRightImage = null;
            this.ButtonForceUpdate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.OnIdleState.BorderRadius = 1;
            this.ButtonForceUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonForceUpdate.OnIdleState.BorderThickness = 1;
            this.ButtonForceUpdate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonForceUpdate.OnIdleState.IconLeftImage = null;
            this.ButtonForceUpdate.OnIdleState.IconRightImage = null;
            this.ButtonForceUpdate.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.OnPressedState.BorderRadius = 1;
            this.ButtonForceUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonForceUpdate.OnPressedState.BorderThickness = 1;
            this.ButtonForceUpdate.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonForceUpdate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonForceUpdate.OnPressedState.IconLeftImage = null;
            this.ButtonForceUpdate.OnPressedState.IconRightImage = null;
            this.ButtonForceUpdate.Size = new System.Drawing.Size(150, 32);
            this.ButtonForceUpdate.TabIndex = 103;
            this.ButtonForceUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonForceUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonForceUpdate.TextMarginLeft = 0;
            this.ButtonForceUpdate.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonForceUpdate.UseDefaultRadiusAndThickness = true;
            this.ButtonForceUpdate.Click += new System.EventHandler(this.ButtonForceUpdate_Click);
            // 
            // DropdownDateFormat
            // 
            this.DropdownDateFormat.BackColor = System.Drawing.Color.Transparent;
            this.DropdownDateFormat.BackgroundColor = System.Drawing.Color.White;
            this.DropdownDateFormat.BorderColor = System.Drawing.Color.Silver;
            this.DropdownDateFormat.BorderRadius = 1;
            this.DropdownDateFormat.Color = System.Drawing.Color.Silver;
            this.DropdownDateFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropdownDateFormat.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropdownDateFormat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropdownDateFormat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropdownDateFormat.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropdownDateFormat.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropdownDateFormat.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropdownDateFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropdownDateFormat.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropdownDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownDateFormat.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Right;
            this.DropdownDateFormat.FillDropDown = true;
            this.DropdownDateFormat.FillIndicator = false;
            this.DropdownDateFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropdownDateFormat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DropdownDateFormat.ForeColor = System.Drawing.Color.Black;
            this.DropdownDateFormat.FormattingEnabled = true;
            this.DropdownDateFormat.Icon = null;
            this.DropdownDateFormat.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Left;
            this.DropdownDateFormat.IndicatorColor = System.Drawing.Color.Gray;
            this.DropdownDateFormat.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Left;
            this.DropdownDateFormat.ItemBackColor = System.Drawing.Color.White;
            this.DropdownDateFormat.ItemBorderColor = System.Drawing.Color.White;
            this.DropdownDateFormat.ItemForeColor = System.Drawing.Color.Black;
            this.DropdownDateFormat.ItemHeight = 26;
            this.DropdownDateFormat.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropdownDateFormat.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropdownDateFormat.Items.AddRange(new object[] {
            "YYYY/MM/DD",
            "YYYY-MM-DD"});
            this.DropdownDateFormat.ItemTopMargin = 3;
            this.DropdownDateFormat.Location = new System.Drawing.Point(212, 129);
            this.DropdownDateFormat.Name = "DropdownDateFormat";
            this.DropdownDateFormat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DropdownDateFormat.Size = new System.Drawing.Size(160, 32);
            this.DropdownDateFormat.TabIndex = 5;
            this.DropdownDateFormat.Text = null;
            this.DropdownDateFormat.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Right;
            this.DropdownDateFormat.TextLeftMargin = 5;
            this.DropdownDateFormat.SelectedIndexChanged += new System.EventHandler(this.DropdownDateFormat_SelectedIndexChanged);
            // 
            // LabelDateFormat
            // 
            this.LabelDateFormat.AutoSize = true;
            this.LabelDateFormat.BackColor = System.Drawing.Color.Transparent;
            this.LabelDateFormat.Location = new System.Drawing.Point(378, 135);
            this.LabelDateFormat.Name = "LabelDateFormat";
            this.LabelDateFormat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDateFormat.Size = new System.Drawing.Size(83, 25);
            this.LabelDateFormat.TabIndex = 102;
            this.LabelDateFormat.Text = "قالب تاریخ:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 112);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(438, 14);
            this.bunifuSeparator1.TabIndex = 101;
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.BackColor = System.Drawing.Color.Transparent;
            this.Notice.Font = new System.Drawing.Font("Vazir", 10F);
            this.Notice.Location = new System.Drawing.Point(76, 84);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(380, 22);
            this.Notice.TabIndex = 100;
            this.Notice.Text = "اگر رنگ ویجت برای شما درست نیست، حالت سازگاری را روشن کنید";
            // 
            // ToggleCompatibility
            // 
            this.ToggleCompatibility.Animation = 5;
            this.ToggleCompatibility.BackColor = System.Drawing.Color.Transparent;
            this.ToggleCompatibility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToggleCompatibility.BackgroundImage")));
            this.ToggleCompatibility.Checked = true;
            this.ToggleCompatibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleCompatibility.InnerCirclePadding = 3;
            this.ToggleCompatibility.Location = new System.Drawing.Point(318, 50);
            this.ToggleCompatibility.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ToggleCompatibility.Name = "ToggleCompatibility";
            this.ToggleCompatibility.Size = new System.Drawing.Size(32, 18);
            this.ToggleCompatibility.TabIndex = 0;
            this.ToggleCompatibility.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.ToggleCompatibility.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Empty;
            toggleState2.BackColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState2.BorderColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderRadius = 1;
            toggleState2.BorderRadiusInner = 1;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.ToggleCompatibility.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.ToggleCompatibility.ToggleStateOn = toggleState3;
            this.ToggleCompatibility.Value = true;
            this.ToggleCompatibility.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.ToggleCompatibility_CheckedChanged);
            // 
            // LabelCompatibility
            // 
            this.LabelCompatibility.AutoSize = true;
            this.LabelCompatibility.BackColor = System.Drawing.Color.Transparent;
            this.LabelCompatibility.Location = new System.Drawing.Point(357, 47);
            this.LabelCompatibility.Name = "LabelCompatibility";
            this.LabelCompatibility.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelCompatibility.Size = new System.Drawing.Size(104, 25);
            this.LabelCompatibility.TabIndex = 98;
            this.LabelCompatibility.Text = "حالت سازگاری:";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(476, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "تنظیمات";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(513, 227);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Topbar);
            this.Font = new System.Drawing.Font("Vazir", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Topbar;
        private System.Windows.Forms.Label LabelName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exit;
        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Notice;
        private Bunifu.UI.WinForms.BunifuToggleSwitch ToggleCompatibility;
        private System.Windows.Forms.Label LabelCompatibility;
        private Bunifu.UI.WinForms.BunifuDropdown DropdownDateFormat;
        private System.Windows.Forms.Label LabelDateFormat;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonForceUpdate;
    }
}