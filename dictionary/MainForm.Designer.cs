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
            this.nameLabel = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.optionComboBox = new System.Windows.Forms.ComboBox();
            this.illustrationImageList = new System.Windows.Forms.ImageList(this.components);
            this.meaningRichTextBox = new System.Windows.Forms.RichTextBox();
            this.suggestedWordComboBox = new System.Windows.Forms.ComboBox();
            this.suggenstionPanel = new System.Windows.Forms.Panel();
            this.speakButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(459, 193);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.wordTextBox.Multiline = true;
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(216, 28);
            this.wordTextBox.TabIndex = 0;
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(2, 6);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(134, 56);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(695, 77);
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
            this.optionComboBox.Location = new System.Drawing.Point(800, 80);
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
            this.meaningRichTextBox.Location = new System.Drawing.Point(586, 275);
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
            this.suggestedWordComboBox.Location = new System.Drawing.Point(459, 256);
            this.suggestedWordComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.suggestedWordComboBox.Name = "suggestedWordComboBox";
            this.suggestedWordComboBox.Size = new System.Drawing.Size(87, 197);
            this.suggestedWordComboBox.TabIndex = 0;
            this.suggestedWordComboBox.SelectedIndexChanged += new System.EventHandler(this.suggestedWordComboBox_SelectedIndexChanged);
            // 
            // suggenstionPanel
            // 
            this.suggenstionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.suggenstionPanel.Location = new System.Drawing.Point(357, 275);
            this.suggenstionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.suggenstionPanel.Name = "suggenstionPanel";
            this.suggenstionPanel.Size = new System.Drawing.Size(90, 197);
            this.suggenstionPanel.TabIndex = 7;
            // 
            // speakButton
            // 
            this.speakButton.BackgroundImage = global::dictionary.Properties.Resources.speakers;
            this.speakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speakButton.Location = new System.Drawing.Point(874, 126);
            this.speakButton.Margin = new System.Windows.Forms.Padding(2);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(34, 38);
            this.speakButton.TabIndex = 9;
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton7);
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.iconButton5);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.panel1.Size = new System.Drawing.Size(190, 472);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 112);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(182, 34);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Translate";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 103);
            this.panel2.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.History;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 152);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(182, 34);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.Text = "History";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 232);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(182, 34);
            this.iconButton5.TabIndex = 15;
            this.iconButton5.Text = "Settings";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 32;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 192);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(182, 34);
            this.iconButton6.TabIndex = 16;
            this.iconButton6.Text = "Bookmark";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton7.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 32;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 272);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.iconButton7.Rotation = 0D;
            this.iconButton7.Size = new System.Drawing.Size(182, 34);
            this.iconButton7.TabIndex = 12;
            this.iconButton7.Text = "Help ";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 312);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(182, 34);
            this.iconButton3.TabIndex = 17;
            this.iconButton3.Text = "Feedback";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(970, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.suggestedWordComboBox);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.meaningRichTextBox);
            this.Controls.Add(this.optionComboBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.suggenstionPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}

