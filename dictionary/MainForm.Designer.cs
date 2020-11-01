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
            this.suggenstionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(12, 79);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wordTextBox.Multiline = true;
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(216, 28);
            this.wordTextBox.TabIndex = 0;
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(464, 75);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Dictionary";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(236, 79);
            this.translateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.optionComboBox.Location = new System.Drawing.Point(340, 79);
            this.optionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.meaningRichTextBox.Location = new System.Drawing.Point(116, 157);
            this.meaningRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.suggestedWordComboBox.Location = new System.Drawing.Point(1, 2);
            this.suggestedWordComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suggestedWordComboBox.Name = "suggestedWordComboBox";
            this.suggestedWordComboBox.Size = new System.Drawing.Size(87, 197);
            this.suggestedWordComboBox.TabIndex = 0;
            this.suggestedWordComboBox.SelectedIndexChanged += new System.EventHandler(this.suggestedWordComboBox_SelectedIndexChanged);
            // 
            // suggenstionPanel
            // 
            this.suggenstionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.suggenstionPanel.Controls.Add(this.suggestedWordComboBox);
            this.suggenstionPanel.Location = new System.Drawing.Point(12, 157);
            this.suggenstionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suggenstionPanel.Name = "suggenstionPanel";
            this.suggenstionPanel.Size = new System.Drawing.Size(90, 196);
            this.suggenstionPanel.TabIndex = 7;
            // 
            // speakButton
            // 
            this.speakButton.BackgroundImage = global::dictionary.Properties.Resources.speakers;
            this.speakButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speakButton.Location = new System.Drawing.Point(12, 111);
            this.speakButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(34, 38);
            this.speakButton.TabIndex = 9;
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(464, 369);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.meaningRichTextBox);
            this.Controls.Add(this.optionComboBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.suggenstionPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.suggenstionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.ComboBox optionComboBox;
        private System.Windows.Forms.ImageList illustrationImageList;
        private System.Windows.Forms.RichTextBox meaningRichTextBox;
        private System.Windows.Forms.ComboBox suggestedWordComboBox;
        private System.Windows.Forms.Panel suggenstionPanel;
        private System.Windows.Forms.Button speakButton;
    }
}

