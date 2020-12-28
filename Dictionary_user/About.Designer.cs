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
            this.labelResult = new System.Windows.Forms.Label();
            this.labeLink = new System.Windows.Forms.Label();
            this.labelBookmark = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.iconButtonHistory = new FontAwesome.Sharp.IconButton();
            this.iconButtonBookmark = new FontAwesome.Sharp.IconButton();
            this.iconButtonFeedback = new FontAwesome.Sharp.IconButton();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelWord1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.labelWord1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox4);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox3);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox2);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel1.Controls.Add(this.iconButtonFeedback);
            this.panel1.Controls.Add(this.labelResult);
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
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelResult.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.labelResult.Location = new System.Drawing.Point(35, 204);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(173, 24);
            this.labelResult.TabIndex = 94;
            this.labelResult.Text = "Our information:";
            // 
            // labeLink
            // 
            this.labeLink.AutoSize = true;
            this.labeLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeLink.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLink.ForeColor = System.Drawing.Color.Gainsboro;
            this.labeLink.Location = new System.Drawing.Point(214, 206);
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
            // iconButtonFeedback
            // 
            this.iconButtonFeedback.FlatAppearance.BorderSize = 0;
            this.iconButtonFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFeedback.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonFeedback.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.iconButtonFeedback.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.iconButtonFeedback.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.iconButtonFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFeedback.IconSize = 32;
            this.iconButtonFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFeedback.Location = new System.Drawing.Point(567, 445);
            this.iconButtonFeedback.Name = "iconButtonFeedback";
            this.iconButtonFeedback.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.iconButtonFeedback.Rotation = 0D;
            this.iconButtonFeedback.Size = new System.Drawing.Size(224, 34);
            this.iconButtonFeedback.TabIndex = 95;
            this.iconButtonFeedback.Text = "Send your feedback";
            this.iconButtonFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFeedback.UseVisualStyleBackColor = true;
            this.iconButtonFeedback.Click += new System.EventHandler(this.iconButtonFeedback_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox1.HintText = "Your title";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(39, 271);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(333, 44);
            this.bunifuMaterialTextbox1.TabIndex = 96;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox2.HintText = "Your name";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(39, 363);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(333, 44);
            this.bunifuMaterialTextbox2.TabIndex = 97;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox3.HintText = "Your email";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(458, 271);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(333, 44);
            this.bunifuMaterialTextbox3.TabIndex = 98;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox4.HintText = "Your phone number";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(458, 363);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(333, 44);
            this.bunifuMaterialTextbox4.TabIndex = 99;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(39, 491);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(752, 167);
            this.richTextBox1.TabIndex = 100;
            this.richTextBox1.Text = "";
            // 
            // labelWord1
            // 
            this.labelWord1.AutoSize = true;
            this.labelWord1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWord1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.labelWord1.Location = new System.Drawing.Point(35, 452);
            this.labelWord1.Name = "labelWord1";
            this.labelWord1.Size = new System.Drawing.Size(147, 22);
            this.labelWord1.TabIndex = 101;
            this.labelWord1.Text = "Your feedback";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
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
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private FontAwesome.Sharp.IconButton iconButtonFeedback;
        private System.Windows.Forms.Label labelWord1;
    }
}