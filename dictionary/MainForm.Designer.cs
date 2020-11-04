namespace dictionary
{
    partial class MainForm
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
            this.illustrationImageList = new System.Windows.Forms.ImageList(this.components);
            this.meaningRichTextBox = new System.Windows.Forms.RichTextBox();
            this.suggestedWordComboBox = new System.Windows.Forms.ComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonTranslate = new FontAwesome.Sharp.IconButton();
            this.btnFeedback = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btn_Bookmark = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnHistory = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDictionary = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.textboxSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonSearch = new FontAwesome.Sharp.IconButton();
            this.pictureBoxFlagLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlagRight = new System.Windows.Forms.PictureBox();
            this.buttonSwitch = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHint4 = new System.Windows.Forms.Label();
            this.labelHint3 = new System.Windows.Forms.Label();
            this.labelHint2 = new System.Windows.Forms.Label();
            this.labelHint1 = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRight)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // illustrationImageList
            // 
            this.illustrationImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.illustrationImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.illustrationImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // meaningRichTextBox
            // 
            this.meaningRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.meaningRichTextBox.BackColor = System.Drawing.Color.White;
            this.meaningRichTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaningRichTextBox.Location = new System.Drawing.Point(467, 96);
            this.meaningRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.meaningRichTextBox.Name = "meaningRichTextBox";
            this.meaningRichTextBox.ReadOnly = true;
            this.meaningRichTextBox.Size = new System.Drawing.Size(220, 202);
            this.meaningRichTextBox.TabIndex = 8;
            this.meaningRichTextBox.Text = "";
            this.meaningRichTextBox.TextChanged += new System.EventHandler(this.meaningRichTextBox_TextChanged);
            // 
            // suggestedWordComboBox
            // 
            this.suggestedWordComboBox.BackColor = System.Drawing.Color.White;
            this.suggestedWordComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.suggestedWordComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestedWordComboBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.suggestedWordComboBox.FormattingEnabled = true;
            this.suggestedWordComboBox.Location = new System.Drawing.Point(200, 96);
            this.suggestedWordComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.suggestedWordComboBox.Name = "suggestedWordComboBox";
            this.suggestedWordComboBox.Size = new System.Drawing.Size(239, 202);
            this.suggestedWordComboBox.TabIndex = 0;
            this.suggestedWordComboBox.SelectedIndexChanged += new System.EventHandler(this.suggestedWordComboBox_SelectedIndexChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.buttonTranslate);
            this.panelMenu.Controls.Add(this.btnFeedback);
            this.panelMenu.Controls.Add(this.btnHelp);
            this.panelMenu.Controls.Add(this.btn_Bookmark);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnHistory);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.panelMenu.Size = new System.Drawing.Size(190, 472);
            this.panelMenu.TabIndex = 10;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.FlatAppearance.BorderSize = 0;
            this.buttonTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTranslate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonTranslate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTranslate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTranslate.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.buttonTranslate.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonTranslate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonTranslate.IconSize = 32;
            this.buttonTranslate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTranslate.Location = new System.Drawing.Point(8, 168);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.buttonTranslate.Rotation = 0D;
            this.buttonTranslate.Size = new System.Drawing.Size(182, 34);
            this.buttonTranslate.TabIndex = 22;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTranslate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFeedback.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFeedback.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            this.btnFeedback.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFeedback.IconSize = 32;
            this.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.Location = new System.Drawing.Point(8, 368);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnFeedback.Rotation = 0D;
            this.btnFeedback.Size = new System.Drawing.Size(182, 34);
            this.btnFeedback.TabIndex = 17;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnHelp.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 32;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(8, 328);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnHelp.Rotation = 0D;
            this.btnHelp.Size = new System.Drawing.Size(182, 34);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help ";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btn_Bookmark
            // 
            this.btn_Bookmark.FlatAppearance.BorderSize = 0;
            this.btn_Bookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bookmark.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Bookmark.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bookmark.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Bookmark.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btn_Bookmark.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Bookmark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Bookmark.IconSize = 32;
            this.btn_Bookmark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bookmark.Location = new System.Drawing.Point(8, 248);
            this.btn_Bookmark.Name = "btn_Bookmark";
            this.btn_Bookmark.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btn_Bookmark.Rotation = 0D;
            this.btn_Bookmark.Size = new System.Drawing.Size(182, 34);
            this.btn_Bookmark.TabIndex = 16;
            this.btn_Bookmark.Text = "Bookmark";
            this.btn_Bookmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bookmark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bookmark.UseVisualStyleBackColor = true;
            this.btn_Bookmark.Click += new System.EventHandler(this.btn_Bookmark_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(8, 288);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnSettings.Rotation = 0D;
            this.btnSettings.Size = new System.Drawing.Size(182, 34);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistory.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistory.IconSize = 32;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(8, 208);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnHistory.Rotation = 0D;
            this.btnHistory.Size = new System.Drawing.Size(182, 34);
            this.btnHistory.TabIndex = 12;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(8, 128);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(182, 34);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Home";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDictionary);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 122);
            this.panel2.TabIndex = 0;
            // 
            // labelDictionary
            // 
            this.labelDictionary.AutoSize = true;
            this.labelDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDictionary.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDictionary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(79)))));
            this.labelDictionary.Location = new System.Drawing.Point(27, 85);
            this.labelDictionary.Name = "labelDictionary";
            this.labelDictionary.Size = new System.Drawing.Size(135, 28);
            this.labelDictionary.TabIndex = 1;
            this.labelDictionary.Text = "Dictionary";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::dictionary.Properties.Resources.languages;
            this.btnHome.Location = new System.Drawing.Point(32, 16);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 66);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.textboxSearch);
            this.panelTitleBar.Controls.Add(this.buttonSearch);
            this.panelTitleBar.Controls.Add(this.pictureBoxFlagLeft);
            this.panelTitleBar.Controls.Add(this.pictureBoxFlagRight);
            this.panelTitleBar.Controls.Add(this.buttonSwitch);
            this.panelTitleBar.Location = new System.Drawing.Point(190, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(784, 82);
            this.panelTitleBar.TabIndex = 11;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(51, 31);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(47, 17);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 35;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(39, 35);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // textboxSearch
            // 
            this.textboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.textboxSearch.HintForeColor = System.Drawing.Color.Gainsboro;
            this.textboxSearch.HintText = "Search English";
            this.textboxSearch.isPassword = false;
            this.textboxSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textboxSearch.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.textboxSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textboxSearch.LineThickness = 2;
            this.textboxSearch.Location = new System.Drawing.Point(139, 19);
            this.textboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(422, 39);
            this.textboxSearch.TabIndex = 14;
            this.textboxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxSearch.OnValueChanged += new System.EventHandler(this.textboxSearch_OnValueChanged);
            this.textboxSearch.DoubleClick += new System.EventHandler(this.textboxSearch_DoubleClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearch.IconSize = 30;
            this.buttonSearch.Location = new System.Drawing.Point(560, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Rotation = 0D;
            this.buttonSearch.Size = new System.Drawing.Size(39, 38);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBoxFlagLeft
            // 
            this.pictureBoxFlagLeft.Image = global::dictionary.Properties.Resources.united_kingdom;
            this.pictureBoxFlagLeft.Location = new System.Drawing.Point(625, 23);
            this.pictureBoxFlagLeft.Name = "pictureBoxFlagLeft";
            this.pictureBoxFlagLeft.Size = new System.Drawing.Size(46, 32);
            this.pictureBoxFlagLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagLeft.TabIndex = 12;
            this.pictureBoxFlagLeft.TabStop = false;
            // 
            // pictureBoxFlagRight
            // 
            this.pictureBoxFlagRight.Image = global::dictionary.Properties.Resources.vietnam;
            this.pictureBoxFlagRight.Location = new System.Drawing.Point(667, 23);
            this.pictureBoxFlagRight.Name = "pictureBoxFlagRight";
            this.pictureBoxFlagRight.Size = new System.Drawing.Size(49, 32);
            this.pictureBoxFlagRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagRight.TabIndex = 13;
            this.pictureBoxFlagRight.TabStop = false;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.buttonSwitch.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.buttonSwitch.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSwitch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSwitch.IconSize = 25;
            this.buttonSwitch.Location = new System.Drawing.Point(722, 24);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Rotation = 0D;
            this.buttonSwitch.Size = new System.Drawing.Size(37, 31);
            this.buttonSwitch.TabIndex = 16;
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.labelHint4);
            this.panelDesktop.Controls.Add(this.labelHint3);
            this.panelDesktop.Controls.Add(this.labelHint2);
            this.panelDesktop.Controls.Add(this.labelHint1);
            this.panelDesktop.Controls.Add(this.labelHint);
            this.panelDesktop.Controls.Add(this.suggestedWordComboBox);
            this.panelDesktop.Controls.Add(this.labelEnglish);
            this.panelDesktop.Controls.Add(this.btnPlay);
            this.panelDesktop.Controls.Add(this.meaningRichTextBox);
            this.panelDesktop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Location = new System.Drawing.Point(190, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(784, 393);
            this.panelDesktop.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dictionary.Properties.Resources.idea;
            this.pictureBox1.Location = new System.Drawing.Point(127, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // labelHint4
            // 
            this.labelHint4.AutoSize = true;
            this.labelHint4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint4.Location = new System.Drawing.Point(16, 259);
            this.labelHint4.Name = "labelHint4";
            this.labelHint4.Size = new System.Drawing.Size(83, 24);
            this.labelHint4.TabIndex = 21;
            this.labelHint4.Text = "despair";
            this.labelHint4.MouseLeave += new System.EventHandler(this.labelHint4_MouseLeave);
            this.labelHint4.MouseHover += new System.EventHandler(this.labelHint4_MouseHover);
            // 
            // labelHint3
            // 
            this.labelHint3.AutoSize = true;
            this.labelHint3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint3.Location = new System.Drawing.Point(16, 219);
            this.labelHint3.Name = "labelHint3";
            this.labelHint3.Size = new System.Drawing.Size(147, 24);
            this.labelHint3.TabIndex = 20;
            this.labelHint3.Text = "collaboration";
            this.labelHint3.MouseLeave += new System.EventHandler(this.labelHint3_MouseLeave);
            this.labelHint3.MouseHover += new System.EventHandler(this.labelHint3_MouseHover);
            // 
            // labelHint2
            // 
            this.labelHint2.AutoSize = true;
            this.labelHint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint2.Location = new System.Drawing.Point(16, 179);
            this.labelHint2.Name = "labelHint2";
            this.labelHint2.Size = new System.Drawing.Size(89, 24);
            this.labelHint2.TabIndex = 19;
            this.labelHint2.Text = "blessing";
            this.labelHint2.MouseLeave += new System.EventHandler(this.labelHint2_MouseLeave);
            this.labelHint2.MouseHover += new System.EventHandler(this.labelHint2_MouseHover);
            // 
            // labelHint1
            // 
            this.labelHint1.AutoSize = true;
            this.labelHint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHint1.Location = new System.Drawing.Point(16, 139);
            this.labelHint1.Name = "labelHint1";
            this.labelHint1.Size = new System.Drawing.Size(82, 24);
            this.labelHint1.TabIndex = 18;
            this.labelHint1.Text = "admire";
            this.labelHint1.MouseLeave += new System.EventHandler(this.labelHint1_MouseLeave);
            this.labelHint1.MouseHover += new System.EventHandler(this.labelHint1_MouseHover);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint.Location = new System.Drawing.Point(13, 99);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(120, 24);
            this.labelHint.TabIndex = 17;
            this.labelHint.Text = "Suggestion";
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEnglish.Image = global::dictionary.Properties.Resources.united_kingdom;
            this.labelEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEnglish.Location = new System.Drawing.Point(151, 40);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(0, 24);
            this.labelEnglish.TabIndex = 11;
            this.labelEnglish.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 35;
            this.btnPlay.Location = new System.Drawing.Point(692, 99);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0D;
            this.btnPlay.Size = new System.Drawing.Size(50, 35);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(970, 472);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dictionary";
            this.TransparencyKey = System.Drawing.Color.DarkSlateBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRight)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList illustrationImageList;
        private System.Windows.Forms.RichTextBox meaningRichTextBox;
        private System.Windows.Forms.ComboBox suggestedWordComboBox;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btn_Bookmark;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnHistory;
        private FontAwesome.Sharp.IconButton btnFeedback;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBoxFlagRight;
        private System.Windows.Forms.PictureBox pictureBoxFlagLeft;
        private FontAwesome.Sharp.IconButton buttonSearch;
        public Bunifu.Framework.UI.BunifuMaterialTextbox textboxSearch;
        private FontAwesome.Sharp.IconButton buttonSwitch;
        private FontAwesome.Sharp.IconButton buttonTranslate;
        private System.Windows.Forms.Label labelHint4;
        private System.Windows.Forms.Label labelHint3;
        private System.Windows.Forms.Label labelHint2;
        private System.Windows.Forms.Label labelHint1;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDictionary;
    }
}

