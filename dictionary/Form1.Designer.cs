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
            this.translateButton = new System.Windows.Forms.Button();
            this.optionComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordMeanGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleImagesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(54, 79);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.wordTextBox.Multiline = true;
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(188, 28);
            this.wordTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(460, 75);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Dictionary";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordMeanGridView
            // 
            this.wordMeanGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.wordMeanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordMeanGridView.Location = new System.Drawing.Point(12, 116);
            this.wordMeanGridView.Margin = new System.Windows.Forms.Padding(2);
            this.wordMeanGridView.Name = "wordMeanGridView";
            this.wordMeanGridView.RowTemplate.Height = 33;
            this.wordMeanGridView.Size = new System.Drawing.Size(216, 202);
            this.wordMeanGridView.TabIndex = 2;
            // 
            // exampleImagesGridView
            // 
            this.exampleImagesGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.exampleImagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exampleImagesGridView.Location = new System.Drawing.Point(230, 116);
            this.exampleImagesGridView.Margin = new System.Windows.Forms.Padding(2);
            this.exampleImagesGridView.Name = "exampleImagesGridView";
            this.exampleImagesGridView.RowTemplate.Height = 33;
            this.exampleImagesGridView.Size = new System.Drawing.Size(216, 202);
            this.exampleImagesGridView.TabIndex = 3;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(248, 79);
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
            this.optionComboBox.Location = new System.Drawing.Point(340, 79);
            this.optionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.optionComboBox.Name = "optionComboBox";
            this.optionComboBox.Size = new System.Drawing.Size(108, 26);
            this.optionComboBox.TabIndex = 6;
            this.optionComboBox.Text = "Anh - Việt";
            this.optionComboBox.SelectedIndexChanged += new System.EventHandler(this.optionComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::dictionary.Properties.Resources.loa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(13, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 29);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(460, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.optionComboBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.exampleImagesGridView);
            this.Controls.Add(this.wordMeanGridView);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.wordTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.wordMeanGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleImagesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView wordMeanGridView;
        private System.Windows.Forms.DataGridView exampleImagesGridView;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.ComboBox optionComboBox;
        private System.Windows.Forms.Button button1;
    }
}

