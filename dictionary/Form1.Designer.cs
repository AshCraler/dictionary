namespace dictionary
{
    partial class mainForm
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
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.wordMeanGridView = new System.Windows.Forms.DataGridView();
            this.exampleImagesGridView = new System.Windows.Forms.DataGridView();
            this.loupeIconPictureBox = new System.Windows.Forms.PictureBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.optionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.wordMeanGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleImagesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loupeIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(81, 152);
            this.wordTextBox.Multiline = true;
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(373, 51);
            this.wordTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(920, 144);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Dictionary";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordMeanGridView
            // 
            this.wordMeanGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.wordMeanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordMeanGridView.Location = new System.Drawing.Point(23, 223);
            this.wordMeanGridView.Name = "wordMeanGridView";
            this.wordMeanGridView.RowTemplate.Height = 33;
            this.wordMeanGridView.Size = new System.Drawing.Size(431, 389);
            this.wordMeanGridView.TabIndex = 2;
            // 
            // exampleImagesGridView
            // 
            this.exampleImagesGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.exampleImagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exampleImagesGridView.Location = new System.Drawing.Point(460, 223);
            this.exampleImagesGridView.Name = "exampleImagesGridView";
            this.exampleImagesGridView.RowTemplate.Height = 33;
            this.exampleImagesGridView.Size = new System.Drawing.Size(431, 389);
            this.exampleImagesGridView.TabIndex = 3;
            // 
            // loupeIconPictureBox
            // 
            this.loupeIconPictureBox.Location = new System.Drawing.Point(23, 152);
            this.loupeIconPictureBox.Name = "loupeIconPictureBox";
            this.loupeIconPictureBox.Size = new System.Drawing.Size(52, 51);
            this.loupeIconPictureBox.TabIndex = 4;
            this.loupeIconPictureBox.TabStop = false;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(472, 152);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(177, 51);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Dịch";
            this.translateButton.UseVisualStyleBackColor = true;
            // 
            // optionComboBox
            // 
            this.optionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionComboBox.FormattingEnabled = true;
            this.optionComboBox.Items.AddRange(new object[] {
            "Anh - Việt",
            "Việt - Anh"});
            this.optionComboBox.Location = new System.Drawing.Point(679, 152);
            this.optionComboBox.Name = "optionComboBox";
            this.optionComboBox.Size = new System.Drawing.Size(212, 41);
            this.optionComboBox.TabIndex = 6;
            this.optionComboBox.Text = "Anh - Việt";
            this.optionComboBox.SelectedIndexChanged += new System.EventHandler(this.optionComboBox_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(920, 619);
            this.Controls.Add(this.optionComboBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.loupeIconPictureBox);
            this.Controls.Add(this.exampleImagesGridView);
            this.Controls.Add(this.wordMeanGridView);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.wordTextBox);
            this.Name = "mainForm";
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.wordMeanGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleImagesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loupeIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView wordMeanGridView;
        private System.Windows.Forms.DataGridView exampleImagesGridView;
        private System.Windows.Forms.PictureBox loupeIconPictureBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.ComboBox optionComboBox;
    }
}

