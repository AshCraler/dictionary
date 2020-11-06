namespace dictionary
{
    partial class Translate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.textBoxMeaning = new System.Windows.Forms.TextBox();
            this.labelMeaning = new System.Windows.Forms.Label();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuTextbox1);
            this.panel1.Controls.Add(this.textBoxMeaning);
            this.panel1.Controls.Add(this.labelMeaning);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 439);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Example:";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(13, 18);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(250, 42);
            this.bunifuTextbox1.TabIndex = 15;
            this.bunifuTextbox1.text = "Type your word here";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.bunifuTextbox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuTextbox1_MouseClick);
            // 
            // textBoxMeaning
            // 
            this.textBoxMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBoxMeaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMeaning.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeaning.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxMeaning.Location = new System.Drawing.Point(52, 126);
            this.textBoxMeaning.Name = "textBoxMeaning";
            this.textBoxMeaning.Size = new System.Drawing.Size(594, 24);
            this.textBoxMeaning.TabIndex = 13;
            this.textBoxMeaning.TextChanged += new System.EventHandler(this.textBoxMeaning_TextChanged);
            // 
            // labelMeaning
            // 
            this.labelMeaning.AutoSize = true;
            this.labelMeaning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeaning.Location = new System.Drawing.Point(32, 85);
            this.labelMeaning.Name = "labelMeaning";
            this.labelMeaning.Size = new System.Drawing.Size(164, 24);
            this.labelMeaning.TabIndex = 12;
            this.labelMeaning.Text = "Word Meaning:";
            this.labelMeaning.Click += new System.EventHandler(this.labelMeaning_Click);
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
            this.btnPlay.Location = new System.Drawing.Point(269, 25);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0D;
            this.btnPlay.Size = new System.Drawing.Size(50, 35);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 439);
            this.Controls.Add(this.panel1);
            this.Name = "Translate";
            this.Text = "Translate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.TextBox textBoxMeaning;
        private System.Windows.Forms.Label labelMeaning;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Label label1;
    }
}