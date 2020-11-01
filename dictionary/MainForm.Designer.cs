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
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.optionComboBox = new System.Windows.Forms.ComboBox();
            this.illustrationImageList = new System.Windows.Forms.ImageList(this.components);
            this.meaningRichTextBox = new System.Windows.Forms.RichTextBox();
            this.suggestedWordComboBox = new System.Windows.Forms.ComboBox();
            this.suggenstionPanel = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.speakButton = new System.Windows.Forms.Button();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnFeedback = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btn_Bookmark = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnHistory = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(415, 94);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.wordTextBox.Multiline = true;
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(216, 28);
            this.wordTextBox.TabIndex = 0;
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(299, 92);
            this.translateButton.Margin = new System.Windows.Forms.Padding(2);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(88, 27);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Dịch";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // optionComboBox
            // 
            this.optionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionComboBox.FormattingEnabled = true;
            this.optionComboBox.Items.AddRange(new object[] {
            "Anh - Việt",
            "Việt - Anh"});
            this.optionComboBox.Location = new System.Drawing.Point(34, 94);
            this.optionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.optionComboBox.Name = "optionComboBox";
            this.optionComboBox.Size = new System.Drawing.Size(108, 26);
            this.optionComboBox.TabIndex = 6;
            this.optionComboBox.Text = "Anh - Việt";
            this.optionComboBox.SelectedIndexChanged += new System.EventHandler(this.optionComboBox_SelectedIndexChanged);
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
            this.meaningRichTextBox.Location = new System.Drawing.Point(299, 155);
            this.meaningRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.meaningRichTextBox.Name = "meaningRichTextBox";
            this.meaningRichTextBox.ReadOnly = true;
            this.meaningRichTextBox.Size = new System.Drawing.Size(332, 198);
            this.meaningRichTextBox.TabIndex = 8;
            this.meaningRichTextBox.Text = "";
            // 
            // suggestedWordComboBox
            // 
            this.suggestedWordComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.suggestedWordComboBox.FormattingEnabled = true;
            this.suggestedWordComboBox.Location = new System.Drawing.Point(34, 155);
            this.suggestedWordComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.suggestedWordComboBox.Name = "suggestedWordComboBox";
            this.suggestedWordComboBox.Size = new System.Drawing.Size(87, 202);
            this.suggestedWordComboBox.TabIndex = 0;
            this.suggestedWordComboBox.SelectedIndexChanged += new System.EventHandler(this.suggestedWordComboBox_SelectedIndexChanged);
            // 
            // suggenstionPanel
            // 
            this.suggenstionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.suggenstionPanel.BackColor = System.Drawing.Color.White;
            this.suggenstionPanel.ForeColor = System.Drawing.Color.GhostWhite;
            this.suggenstionPanel.Location = new System.Drawing.Point(167, 155);
            this.suggenstionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.suggenstionPanel.Name = "suggenstionPanel";
            this.suggenstionPanel.Size = new System.Drawing.Size(90, 198);
            this.suggenstionPanel.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 122);
            this.panel2.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
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
            this.labelTitleChildForm.Location = new System.Drawing.Point(51, 32);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(47, 17);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.translateButton);
            this.panelDesktop.Controls.Add(this.suggenstionPanel);
            this.panelDesktop.Controls.Add(this.suggestedWordComboBox);
            this.panelDesktop.Controls.Add(this.speakButton);
            this.panelDesktop.Controls.Add(this.wordTextBox);
            this.panelDesktop.Controls.Add(this.optionComboBox);
            this.panelDesktop.Controls.Add(this.meaningRichTextBox);
            this.panelDesktop.Location = new System.Drawing.Point(190, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(784, 390);
            this.panelDesktop.TabIndex = 12;
            // 
            // speakButton
            // 
            this.speakButton.BackgroundImage = global::dictionary.Properties.Resources.speakers;
            this.speakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speakButton.Location = new System.Drawing.Point(187, 92);
            this.speakButton.Margin = new System.Windows.Forms.Padding(2);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(34, 38);
            this.speakButton.TabIndex = 9;
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
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
            this.btnFeedback.Location = new System.Drawing.Point(3, 327);
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
            this.btnHelp.Location = new System.Drawing.Point(0, 287);
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
            this.btn_Bookmark.Location = new System.Drawing.Point(0, 207);
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
            this.btnSettings.Location = new System.Drawing.Point(0, 247);
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
            this.btnHistory.Location = new System.Drawing.Point(3, 167);
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
            this.iconButton1.Location = new System.Drawing.Point(5, 128);
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
            // btnHome
            // 
            this.btnHome.Image = global::dictionary.Properties.Resources.languages;
            this.btnHome.Location = new System.Drawing.Point(14, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(119, 79);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.ComboBox optionComboBox;
        private System.Windows.Forms.ImageList illustrationImageList;
        private System.Windows.Forms.RichTextBox meaningRichTextBox;
        private System.Windows.Forms.ComboBox suggestedWordComboBox;
        private System.Windows.Forms.Panel suggenstionPanel;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btn_Bookmark;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnHistory;
        private FontAwesome.Sharp.IconButton btnFeedback;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

