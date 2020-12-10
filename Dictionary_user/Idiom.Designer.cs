namespace Dictionary_user
{
    partial class Idiom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelSuggestion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelBookmark = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSwitch = new FontAwesome.Sharp.IconButton();
            this.pictureBoxFlagRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlagLeft = new System.Windows.Forms.PictureBox();
            this.iconButtonHistory = new FontAwesome.Sharp.IconButton();
            this.iconButtonBookmark = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panelResult);
            this.panel1.Controls.Add(this.panelSuggestion);
            this.panel1.Controls.Add(this.labelBookmark);
            this.panel1.Controls.Add(this.labelHistory);
            this.panel1.Controls.Add(this.iconButtonHistory);
            this.panel1.Controls.Add(this.iconButtonBookmark);
            this.panel1.Location = new System.Drawing.Point(-4, -150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 840);
            this.panel1.TabIndex = 1;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelResult.Controls.Add(this.label1);
            this.panelResult.Controls.Add(this.pictureBox1);
            this.panelResult.Controls.Add(this.pictureBoxFlagLeft);
            this.panelResult.Controls.Add(this.labelLanguage);
            this.panelResult.Controls.Add(this.buttonSwitch);
            this.panelResult.Controls.Add(this.pictureBoxFlagRight);
            this.panelResult.Location = new System.Drawing.Point(16, 470);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(781, 355);
            this.panelResult.TabIndex = 94;
            // 
            // panelSuggestion
            // 
            this.panelSuggestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelSuggestion.Location = new System.Drawing.Point(16, 148);
            this.panelSuggestion.Name = "panelSuggestion";
            this.panelSuggestion.Size = new System.Drawing.Size(781, 316);
            this.panelSuggestion.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(617, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bookmark time";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLanguage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLanguage.Location = new System.Drawing.Point(58, 267);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(194, 24);
            this.labelLanguage.TabIndex = 18;
            this.labelLanguage.Text = "Vietnamese idiom";
            // 
            // labelBookmark
            // 
            this.labelBookmark.AutoSize = true;
            this.labelBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBookmark.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookmark.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBookmark.Location = new System.Drawing.Point(35, 123);
            this.labelBookmark.Name = "labelBookmark";
            this.labelBookmark.Size = new System.Drawing.Size(197, 22);
            this.labelBookmark.TabIndex = 92;
            this.labelBookmark.Text = "Delete all Bookmarks";
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHistory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHistory.Location = new System.Drawing.Point(35, 69);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(123, 22);
            this.labelHistory.TabIndex = 91;
            this.labelHistory.Text = "Clear History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dictionary_user.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(565, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.buttonSwitch.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.buttonSwitch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(98)))), ((int)(((byte)(121)))));
            this.buttonSwitch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSwitch.IconSize = 25;
            this.buttonSwitch.Location = new System.Drawing.Point(304, 267);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Rotation = 0D;
            this.buttonSwitch.Size = new System.Drawing.Size(37, 31);
            this.buttonSwitch.TabIndex = 21;
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // pictureBoxFlagRight
            // 
            this.pictureBoxFlagRight.Image = global::Dictionary_user.Properties.Resources.united_kingdom;
            this.pictureBoxFlagRight.Location = new System.Drawing.Point(347, 267);
            this.pictureBoxFlagRight.Name = "pictureBoxFlagRight";
            this.pictureBoxFlagRight.Size = new System.Drawing.Size(46, 32);
            this.pictureBoxFlagRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagRight.TabIndex = 20;
            this.pictureBoxFlagRight.TabStop = false;
            // 
            // pictureBoxFlagLeft
            // 
            this.pictureBoxFlagLeft.Image = global::Dictionary_user.Properties.Resources.vietnam;
            this.pictureBoxFlagLeft.Location = new System.Drawing.Point(3, 259);
            this.pictureBoxFlagLeft.Name = "pictureBoxFlagLeft";
            this.pictureBoxFlagLeft.Size = new System.Drawing.Size(49, 32);
            this.pictureBoxFlagLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagLeft.TabIndex = 19;
            this.pictureBoxFlagLeft.TabStop = false;
            // 
            // iconButtonHistory
            // 
            this.iconButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHistory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonHistory.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconButtonHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHistory.IconSize = 32;
            this.iconButtonHistory.Location = new System.Drawing.Point(383, 66);
            this.iconButtonHistory.Name = "iconButtonHistory";
            this.iconButtonHistory.Rotation = 0D;
            this.iconButtonHistory.Size = new System.Drawing.Size(43, 33);
            this.iconButtonHistory.TabIndex = 90;
            this.iconButtonHistory.UseVisualStyleBackColor = true;
            // 
            // iconButtonBookmark
            // 
            this.iconButtonBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBookmark.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonBookmark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonBookmark.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonBookmark.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.iconButtonBookmark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBookmark.IconSize = 32;
            this.iconButtonBookmark.Location = new System.Drawing.Point(383, 120);
            this.iconButtonBookmark.Name = "iconButtonBookmark";
            this.iconButtonBookmark.Rotation = 0D;
            this.iconButtonBookmark.Size = new System.Drawing.Size(43, 33);
            this.iconButtonBookmark.TabIndex = 89;
            this.iconButtonBookmark.UseVisualStyleBackColor = true;
            // 
            // Idiom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.panel1);
            this.Name = "Idiom";
            this.Text = "Idiom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBookmark;
        private System.Windows.Forms.Label labelHistory;
        private FontAwesome.Sharp.IconButton iconButtonHistory;
        private FontAwesome.Sharp.IconButton iconButtonBookmark;
        private System.Windows.Forms.Panel panelSuggestion;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.PictureBox pictureBoxFlagLeft;
        private System.Windows.Forms.PictureBox pictureBoxFlagRight;
        private FontAwesome.Sharp.IconButton buttonSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        //public System.Windows.Forms.Label labelIdiom1;
    }
}