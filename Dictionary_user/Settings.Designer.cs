namespace Dictionary_user
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHint1 = new System.Windows.Forms.Label();
            this.loginButton = new FontAwesome.Sharp.IconButton();
            this.checkboxSound = new System.Windows.Forms.CheckBox();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.accountTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelHint1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.checkboxSound);
            this.panel1.Location = new System.Drawing.Point(-10, -12);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 1442);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(117, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Account:";
            // 
            // labelHint1
            // 
            this.labelHint1.AutoSize = true;
            this.labelHint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHint1.Location = new System.Drawing.Point(93, 286);
            this.labelHint1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHint1.Name = "labelHint1";
            this.labelHint1.Size = new System.Drawing.Size(167, 37);
            this.labelHint1.TabIndex = 19;
            this.labelHint1.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.loginButton.IconColor = System.Drawing.Color.Gainsboro;
            this.loginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginButton.IconSize = 32;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(337, 397);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(16, 0, 30, 0);
            this.loginButton.Rotation = 0D;
            this.loginButton.Size = new System.Drawing.Size(364, 65);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login as Administrator";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkboxSound
            // 
            this.checkboxSound.AutoSize = true;
            this.checkboxSound.Checked = true;
            this.checkboxSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxSound.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkboxSound.Location = new System.Drawing.Point(34, 75);
            this.checkboxSound.Margin = new System.Windows.Forms.Padding(6);
            this.checkboxSound.Name = "checkboxSound";
            this.checkboxSound.Size = new System.Drawing.Size(172, 52);
            this.checkboxSound.TabIndex = 0;
            this.checkboxSound.Text = "Sound";
            this.checkboxSound.UseVisualStyleBackColor = true;
            // 
            // accountTextBox
            // 
            this.accountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.accountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountTextBox.Location = new System.Drawing.Point(293, 167);
            this.accountTextBox.Multiline = true;
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(398, 47);
            this.accountTextBox.TabIndex = 21;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordTextBox.Location = new System.Drawing.Point(293, 276);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(398, 47);
            this.passwordTextBox.TabIndex = 22;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1398);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkboxSound;
        private FontAwesome.Sharp.IconButton loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHint1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox accountTextBox;
    }
}