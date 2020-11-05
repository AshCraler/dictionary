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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.textBoxMeaning);
            this.panel1.Controls.Add(this.labelMeaning);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 454);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type your word";
            // 
            // textBoxMeaning
            // 
            this.textBoxMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBoxMeaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMeaning.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeaning.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxMeaning.Location = new System.Drawing.Point(34, 92);
            this.textBoxMeaning.Name = "textBoxMeaning";
            this.textBoxMeaning.Size = new System.Drawing.Size(512, 24);
            this.textBoxMeaning.TabIndex = 13;
            this.textBoxMeaning.Text = "-Word meaning";
            // 
            // labelMeaning
            // 
            this.labelMeaning.AutoSize = true;
            this.labelMeaning.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeaning.Location = new System.Drawing.Point(17, 52);
            this.labelMeaning.Name = "labelMeaning";
            this.labelMeaning.Size = new System.Drawing.Size(105, 24);
            this.labelMeaning.TabIndex = 12;
            this.labelMeaning.Text = "Meaning:";
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
            this.btnPlay.Location = new System.Drawing.Point(201, 11);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMeaning;
        private System.Windows.Forms.Label labelMeaning;
    }
}