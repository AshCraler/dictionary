﻿namespace Dictionary_user
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelBookmarkTime = new System.Windows.Forms.Label();
            this.pictureBoxBookmarkTime = new System.Windows.Forms.PictureBox();
            this.iconButtonUpdateData = new FontAwesome.Sharp.IconButton();
            this.Update = new System.Windows.Forms.Label();
            this.labelBookmark = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.iconButtonHistory = new FontAwesome.Sharp.IconButton();
            this.iconButtonBookmark = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookmarkTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelBookmarkTime);
            this.panel1.Controls.Add(this.pictureBoxBookmarkTime);
            this.panel1.Controls.Add(this.iconButtonUpdateData);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.labelBookmark);
            this.panel1.Controls.Add(this.labelHistory);
            this.panel1.Controls.Add(this.iconButtonHistory);
            this.panel1.Controls.Add(this.iconButtonBookmark);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 750);
            this.panel1.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Location = new System.Drawing.Point(241, 233);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(86, 22);
            this.labelTime.TabIndex = 97;
            this.labelTime.Text = "00:00:00";
            this.labelTime.Visible = false;
            // 
            // labelBookmarkTime
            // 
            this.labelBookmarkTime.AutoSize = true;
            this.labelBookmarkTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBookmarkTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookmarkTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBookmarkTime.Location = new System.Drawing.Point(35, 231);
            this.labelBookmarkTime.Name = "labelBookmarkTime";
            this.labelBookmarkTime.Size = new System.Drawing.Size(117, 24);
            this.labelBookmarkTime.TabIndex = 96;
            this.labelBookmarkTime.Text = "Save time:";
            // 
            // pictureBoxBookmarkTime
            // 
            this.pictureBoxBookmarkTime.Image = global::Dictionary_user.Properties.Resources.clock;
            this.pictureBoxBookmarkTime.Location = new System.Drawing.Point(498, 223);
            this.pictureBoxBookmarkTime.Name = "pictureBoxBookmarkTime";
            this.pictureBoxBookmarkTime.Size = new System.Drawing.Size(46, 32);
            this.pictureBoxBookmarkTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBookmarkTime.TabIndex = 95;
            this.pictureBoxBookmarkTime.TabStop = false;
            // 
            // iconButtonUpdateData
            // 
            this.iconButtonUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUpdateData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonUpdateData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonUpdateData.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButtonUpdateData.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.iconButtonUpdateData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateData.IconSize = 32;
            this.iconButtonUpdateData.Location = new System.Drawing.Point(498, 175);
            this.iconButtonUpdateData.Name = "iconButtonUpdateData";
            this.iconButtonUpdateData.Rotation = 0D;
            this.iconButtonUpdateData.Size = new System.Drawing.Size(43, 33);
            this.iconButtonUpdateData.TabIndex = 94;
            this.iconButtonUpdateData.UseVisualStyleBackColor = true;
            this.iconButtonUpdateData.Click += new System.EventHandler(this.iconButtonUpdateData_Click);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.Gainsboro;
            this.Update.Location = new System.Drawing.Point(35, 178);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(208, 22);
            this.Update.TabIndex = 93;
            this.Update.Text = "Save Translated Data";
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
            // iconButtonHistory
            // 
            this.iconButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHistory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonHistory.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconButtonHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHistory.IconSize = 32;
            this.iconButtonHistory.Location = new System.Drawing.Point(498, 66);
            this.iconButtonHistory.Name = "iconButtonHistory";
            this.iconButtonHistory.Rotation = 0D;
            this.iconButtonHistory.Size = new System.Drawing.Size(43, 33);
            this.iconButtonHistory.TabIndex = 90;
            this.iconButtonHistory.UseVisualStyleBackColor = true;
            this.iconButtonHistory.Click += new System.EventHandler(this.iconButtonHistory_Click);
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
            this.iconButtonBookmark.Location = new System.Drawing.Point(498, 123);
            this.iconButtonBookmark.Name = "iconButtonBookmark";
            this.iconButtonBookmark.Rotation = 0D;
            this.iconButtonBookmark.Size = new System.Drawing.Size(43, 33);
            this.iconButtonBookmark.TabIndex = 89;
            this.iconButtonBookmark.UseVisualStyleBackColor = true;
            this.iconButtonBookmark.Click += new System.EventHandler(this.iconButtonBookmark_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 727);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookmarkTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonHistory;
        private FontAwesome.Sharp.IconButton iconButtonBookmark;
        private System.Windows.Forms.Label labelBookmark;
        private System.Windows.Forms.Label labelHistory;
        private FontAwesome.Sharp.IconButton iconButtonUpdateData;
        private System.Windows.Forms.Label Update;
        private System.Windows.Forms.PictureBox pictureBoxBookmarkTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelBookmarkTime;
    }
}