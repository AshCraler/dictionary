namespace Dictionary_user
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeLink = new System.Windows.Forms.Label();
            this.labelBookmark = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.iconButtonHistory = new FontAwesome.Sharp.IconButton();
            this.iconButtonBookmark = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.labeLink);
            this.panel1.Controls.Add(this.labelBookmark);
            this.panel1.Controls.Add(this.labelHistory);
            this.panel1.Controls.Add(this.iconButtonHistory);
            this.panel1.Controls.Add(this.iconButtonBookmark);
            this.panel1.Location = new System.Drawing.Point(-27, -150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 800);
            this.panel1.TabIndex = 1;
            // 
            // labeLink
            // 
            this.labeLink.AutoSize = true;
            this.labeLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeLink.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLink.ForeColor = System.Drawing.Color.Gainsboro;
            this.labeLink.Location = new System.Drawing.Point(46, 198);
            this.labeLink.Name = "labeLink";
            this.labeLink.Size = new System.Drawing.Size(380, 22);
            this.labeLink.TabIndex = 93;
            this.labeLink.Text = "https://github.com/AshCraler/dictionary";
            this.labeLink.Click += new System.EventHandler(this.labeLink_Click);
            this.labeLink.MouseLeave += new System.EventHandler(this.labeLink_MouseLeave);
            this.labeLink.MouseHover += new System.EventHandler(this.labeLink_MouseHover);
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
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.panel1);
            this.Name = "About";
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBookmark;
        private System.Windows.Forms.Label labelHistory;
        private FontAwesome.Sharp.IconButton iconButtonHistory;
        private FontAwesome.Sharp.IconButton iconButtonBookmark;
        private System.Windows.Forms.Label labeLink;
    }
}