namespace HaftRokh
{
    partial class About
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Topbar = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelName = new System.Windows.Forms.Label();
            this.Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Description = new System.Windows.Forms.Label();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelUpdateStatus = new System.Windows.Forms.Label();
            this.Title3 = new System.Windows.Forms.Label();
            this.Separator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.Title2 = new System.Windows.Forms.Label();
            this.Separator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.PictureBoxTelegram = new System.Windows.Forms.PictureBox();
            this.LabelTelegram = new System.Windows.Forms.Label();
            this.PictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.LabelDonate = new System.Windows.Forms.Label();
            this.PictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.PictureBoxGithub = new System.Windows.Forms.PictureBox();
            this.LabelGithub = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Topbar.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 25;
            this.Elipse.TargetControl = this;
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
            this.Topbar.Name = "Topbar";
            this.Topbar.ShowBorders = true;
            this.Topbar.Size = new System.Drawing.Size(502, 33);
            this.Topbar.TabIndex = 0;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(9, 6);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(54, 25);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "About";
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Exit.CustomizableEdges = borderEdges2;
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
            this.Exit.Location = new System.Drawing.Point(475, 9);
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
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit.TextMarginLeft = 0;
            this.Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Exit.UseDefaultRadiusAndThickness = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(17, 29);
            this.Description.Name = "Description";
            this.Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Description.Size = new System.Drawing.Size(441, 169);
            this.Description.TabIndex = 2;
            this.Description.Text = resources.GetString("Description.Text");
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.White;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 25;
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.ButtonUpdate);
            this.Panel.Controls.Add(this.PictureBoxLoading);
            this.Panel.Controls.Add(this.LabelVersion);
            this.Panel.Controls.Add(this.LabelUpdateStatus);
            this.Panel.Controls.Add(this.Title3);
            this.Panel.Controls.Add(this.Separator2);
            this.Panel.Controls.Add(this.Title2);
            this.Panel.Controls.Add(this.Separator1);
            this.Panel.Controls.Add(this.PictureBoxTelegram);
            this.Panel.Controls.Add(this.LabelTelegram);
            this.Panel.Controls.Add(this.PictureBoxDonate);
            this.Panel.Controls.Add(this.LabelDonate);
            this.Panel.Controls.Add(this.PictureBoxEmail);
            this.Panel.Controls.Add(this.LabelEmail);
            this.Panel.Controls.Add(this.PictureBoxGithub);
            this.Panel.Controls.Add(this.LabelGithub);
            this.Panel.Controls.Add(this.Title);
            this.Panel.Controls.Add(this.Description);
            this.Panel.Location = new System.Drawing.Point(14, 45);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(476, 514);
            this.Panel.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.AllowAnimations = true;
            this.ButtonUpdate.AllowMouseEffects = true;
            this.ButtonUpdate.AllowToggling = false;
            this.ButtonUpdate.AnimationSpeed = 200;
            this.ButtonUpdate.AutoGenerateColors = false;
            this.ButtonUpdate.AutoRoundBorders = false;
            this.ButtonUpdate.AutoSizeLeftIcon = true;
            this.ButtonUpdate.AutoSizeRightIcon = true;
            this.ButtonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUpdate.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ButtonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate.BackgroundImage")));
            this.ButtonUpdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonUpdate.ButtonText = "به روز رسانی";
            this.ButtonUpdate.ButtonTextMarginLeft = 0;
            this.ButtonUpdate.ColorContrastOnClick = 45;
            this.ButtonUpdate.ColorContrastOnHover = 45;
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonUpdate.CustomizableEdges = borderEdges1;
            this.ButtonUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonUpdate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonUpdate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonUpdate.Font = new System.Drawing.Font("Vazir", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonUpdate.IconMarginLeft = 11;
            this.ButtonUpdate.IconPadding = 10;
            this.ButtonUpdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonUpdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonUpdate.IconSize = 25;
            this.ButtonUpdate.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonUpdate.IdleBorderRadius = 15;
            this.ButtonUpdate.IdleBorderThickness = 1;
            this.ButtonUpdate.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonUpdate.IdleIconLeftImage = null;
            this.ButtonUpdate.IdleIconRightImage = null;
            this.ButtonUpdate.IndicateFocus = false;
            this.ButtonUpdate.Location = new System.Drawing.Point(20, 460);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonUpdate.OnDisabledState.BorderRadius = 15;
            this.ButtonUpdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonUpdate.OnDisabledState.BorderThickness = 1;
            this.ButtonUpdate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonUpdate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonUpdate.OnDisabledState.IconLeftImage = null;
            this.ButtonUpdate.OnDisabledState.IconRightImage = null;
            this.ButtonUpdate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ButtonUpdate.onHoverState.BorderRadius = 15;
            this.ButtonUpdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonUpdate.onHoverState.BorderThickness = 1;
            this.ButtonUpdate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ButtonUpdate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.onHoverState.IconLeftImage = null;
            this.ButtonUpdate.onHoverState.IconRightImage = null;
            this.ButtonUpdate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonUpdate.OnIdleState.BorderRadius = 15;
            this.ButtonUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonUpdate.OnIdleState.BorderThickness = 1;
            this.ButtonUpdate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonUpdate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.OnIdleState.IconLeftImage = null;
            this.ButtonUpdate.OnIdleState.IconRightImage = null;
            this.ButtonUpdate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonUpdate.OnPressedState.BorderRadius = 15;
            this.ButtonUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonUpdate.OnPressedState.BorderThickness = 1;
            this.ButtonUpdate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonUpdate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.OnPressedState.IconLeftImage = null;
            this.ButtonUpdate.OnPressedState.IconRightImage = null;
            this.ButtonUpdate.Size = new System.Drawing.Size(91, 39);
            this.ButtonUpdate.TabIndex = 99;
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonUpdate.TextMarginLeft = 0;
            this.ButtonUpdate.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonUpdate.UseDefaultRadiusAndThickness = true;
            this.ButtonUpdate.Visible = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // PictureBoxLoading
            // 
            this.PictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLoading.Image")));
            this.PictureBoxLoading.Location = new System.Drawing.Point(433, 480);
            this.PictureBoxLoading.Name = "PictureBoxLoading";
            this.PictureBoxLoading.Size = new System.Drawing.Size(18, 18);
            this.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLoading.TabIndex = 82;
            this.PictureBoxLoading.TabStop = false;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.Font = new System.Drawing.Font("Vazir", 11F);
            this.LabelVersion.Location = new System.Drawing.Point(264, 451);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelVersion.Size = new System.Drawing.Size(190, 27);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "نسخه فعلی:";
            // 
            // LabelUpdateStatus
            // 
            this.LabelUpdateStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelUpdateStatus.Font = new System.Drawing.Font("Vazir", 11F);
            this.LabelUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelUpdateStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelUpdateStatus.Location = new System.Drawing.Point(140, 478);
            this.LabelUpdateStatus.Name = "LabelUpdateStatus";
            this.LabelUpdateStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelUpdateStatus.Size = new System.Drawing.Size(289, 21);
            this.LabelUpdateStatus.TabIndex = 81;
            this.LabelUpdateStatus.Text = "در حال اتصال به سرور...";
            this.LabelUpdateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title3
            // 
            this.Title3.BackColor = System.Drawing.Color.Transparent;
            this.Title3.Location = new System.Drawing.Point(180, 414);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(116, 25);
            this.Title3.TabIndex = 98;
            this.Title3.Text = "بررسی آپدیت";
            this.Title3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Separator2
            // 
            this.Separator2.BackColor = System.Drawing.Color.Transparent;
            this.Separator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Separator2.BackgroundImage")));
            this.Separator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Separator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.Separator2.LineColor = System.Drawing.Color.Silver;
            this.Separator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.Separator2.LineThickness = 1;
            this.Separator2.Location = new System.Drawing.Point(20, 414);
            this.Separator2.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.Separator2.Name = "Separator2";
            this.Separator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator2.Size = new System.Drawing.Size(433, 25);
            this.Separator2.TabIndex = 97;
            // 
            // Title2
            // 
            this.Title2.BackColor = System.Drawing.Color.Transparent;
            this.Title2.Location = new System.Drawing.Point(180, 199);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(116, 25);
            this.Title2.TabIndex = 96;
            this.Title2.Text = "راه های ارتباطی";
            this.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Separator1
            // 
            this.Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Separator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Separator1.BackgroundImage")));
            this.Separator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Separator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.Separator1.LineColor = System.Drawing.Color.Silver;
            this.Separator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.Separator1.LineThickness = 1;
            this.Separator1.Location = new System.Drawing.Point(20, 204);
            this.Separator1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Separator1.Name = "Separator1";
            this.Separator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator1.Size = new System.Drawing.Size(435, 13);
            this.Separator1.TabIndex = 95;
            // 
            // PictureBoxTelegram
            // 
            this.PictureBoxTelegram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxTelegram.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxTelegram.Image = global::HaftRokh.Properties.Resources.telegram;
            this.PictureBoxTelegram.Location = new System.Drawing.Point(428, 283);
            this.PictureBoxTelegram.Name = "PictureBoxTelegram";
            this.PictureBoxTelegram.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxTelegram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTelegram.TabIndex = 94;
            this.PictureBoxTelegram.TabStop = false;
            this.PictureBoxTelegram.Click += new System.EventHandler(this.LabelTelegram_Click);
            // 
            // LabelTelegram
            // 
            this.LabelTelegram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTelegram.AutoSize = true;
            this.LabelTelegram.BackColor = System.Drawing.Color.Transparent;
            this.LabelTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTelegram.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.LabelTelegram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelTelegram.Location = new System.Drawing.Point(233, 286);
            this.LabelTelegram.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTelegram.Name = "LabelTelegram";
            this.LabelTelegram.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelTelegram.Size = new System.Drawing.Size(183, 25);
            this.LabelTelegram.TabIndex = 93;
            this.LabelTelegram.Text = "تلگرام: CodeMageIR@";
            this.LabelTelegram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelTelegram.Click += new System.EventHandler(this.LabelTelegram_Click);
            // 
            // PictureBoxDonate
            // 
            this.PictureBoxDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxDonate.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxDonate.Image = global::HaftRokh.Properties.Resources.donate;
            this.PictureBoxDonate.Location = new System.Drawing.Point(428, 372);
            this.PictureBoxDonate.Name = "PictureBoxDonate";
            this.PictureBoxDonate.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxDonate.TabIndex = 92;
            this.PictureBoxDonate.TabStop = false;
            this.PictureBoxDonate.Click += new System.EventHandler(this.LabelDonate_Click);
            // 
            // LabelDonate
            // 
            this.LabelDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDonate.AutoSize = true;
            this.LabelDonate.BackColor = System.Drawing.Color.Transparent;
            this.LabelDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDonate.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.LabelDonate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelDonate.Location = new System.Drawing.Point(318, 374);
            this.LabelDonate.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDonate.Name = "LabelDonate";
            this.LabelDonate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDonate.Size = new System.Drawing.Size(98, 25);
            this.LabelDonate.TabIndex = 91;
            this.LabelDonate.Text = "حمایت مالی";
            this.LabelDonate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelDonate.Click += new System.EventHandler(this.LabelDonate_Click);
            // 
            // PictureBoxEmail
            // 
            this.PictureBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxEmail.Image = global::HaftRokh.Properties.Resources.envelope;
            this.PictureBoxEmail.Location = new System.Drawing.Point(428, 239);
            this.PictureBoxEmail.Name = "PictureBoxEmail";
            this.PictureBoxEmail.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEmail.TabIndex = 90;
            this.PictureBoxEmail.TabStop = false;
            this.PictureBoxEmail.Click += new System.EventHandler(this.LabelEmail_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEmail.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.LabelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelEmail.Location = new System.Drawing.Point(204, 241);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelEmail.Size = new System.Drawing.Size(212, 25);
            this.LabelEmail.TabIndex = 89;
            this.LabelEmail.Text = "ایمیل: Info@CodeMage.ir";
            this.LabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelEmail.Click += new System.EventHandler(this.LabelEmail_Click);
            // 
            // PictureBoxGithub
            // 
            this.PictureBoxGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxGithub.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxGithub.Image = global::HaftRokh.Properties.Resources.github;
            this.PictureBoxGithub.Location = new System.Drawing.Point(428, 331);
            this.PictureBoxGithub.Name = "PictureBoxGithub";
            this.PictureBoxGithub.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxGithub.TabIndex = 88;
            this.PictureBoxGithub.TabStop = false;
            this.PictureBoxGithub.Click += new System.EventHandler(this.LabelGithub_Click);
            // 
            // LabelGithub
            // 
            this.LabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGithub.AutoSize = true;
            this.LabelGithub.BackColor = System.Drawing.Color.Transparent;
            this.LabelGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelGithub.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.LabelGithub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelGithub.Location = new System.Drawing.Point(341, 333);
            this.LabelGithub.Margin = new System.Windows.Forms.Padding(0);
            this.LabelGithub.Name = "LabelGithub";
            this.LabelGithub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelGithub.Size = new System.Drawing.Size(75, 25);
            this.LabelGithub.TabIndex = 87;
            this.LabelGithub.Text = "گیت‌هاب";
            this.LabelGithub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelGithub.Click += new System.EventHandler(this.LabelGithub_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(476, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "درباره هفت‌رخ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(502, 586);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Topbar);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTelegram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGithub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel Topbar;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label LabelName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exit;
        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Title2;
        private Bunifu.UI.WinForms.BunifuSeparator Separator1;
        private System.Windows.Forms.PictureBox PictureBoxTelegram;
        private System.Windows.Forms.Label LabelTelegram;
        private System.Windows.Forms.PictureBox PictureBoxDonate;
        private System.Windows.Forms.Label LabelDonate;
        private System.Windows.Forms.PictureBox PictureBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.PictureBox PictureBoxGithub;
        private System.Windows.Forms.Label LabelGithub;
        private System.Windows.Forms.Label Title3;
        private Bunifu.UI.WinForms.BunifuSeparator Separator2;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.PictureBox PictureBoxLoading;
        private System.Windows.Forms.Label LabelUpdateStatus;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonUpdate;
    }
}