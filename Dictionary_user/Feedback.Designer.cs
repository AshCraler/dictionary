namespace Dictionary_user
{
    partial class Feedback
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.contributeButton = new FontAwesome.Sharp.IconButton();
            this.problemReportButton = new FontAwesome.Sharp.IconButton();
            this.contributePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.buttonSendFeedBack = new FontAwesome.Sharp.IconButton();
            this.yourOpinionLabel = new System.Windows.Forms.Label();
            this.textBoxContent = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.textBoxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contentPanel.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.contributePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.contentPanel.Controls.Add(this.tabPanel);
            this.contentPanel.Controls.Add(this.contributePanel);
            this.contentPanel.Location = new System.Drawing.Point(-14, -56);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(6);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1618, 1562);
            this.contentPanel.TabIndex = 0;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.contributeButton);
            this.tabPanel.Controls.Add(this.problemReportButton);
            this.tabPanel.Location = new System.Drawing.Point(16, 58);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(1599, 100);
            this.tabPanel.TabIndex = 27;
            // 
            // contributeButton
            // 
            this.contributeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.contributeButton.FlatAppearance.BorderSize = 0;
            this.contributeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contributeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.contributeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.contributeButton.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.contributeButton.IconColor = System.Drawing.Color.Gainsboro;
            this.contributeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.contributeButton.IconSize = 40;
            this.contributeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contributeButton.Location = new System.Drawing.Point(0, 0);
            this.contributeButton.Margin = new System.Windows.Forms.Padding(6);
            this.contributeButton.Name = "contributeButton";
            this.contributeButton.Padding = new System.Windows.Forms.Padding(16, 0, 30, 0);
            this.contributeButton.Rotation = 0D;
            this.contributeButton.Size = new System.Drawing.Size(530, 100);
            this.contributeButton.TabIndex = 13;
            this.contributeButton.Text = "Contribute";
            this.contributeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contributeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contributeButton.UseVisualStyleBackColor = false;
            this.contributeButton.Click += new System.EventHandler(this.contributeButton_Click);
            // 
            // problemReportButton
            // 
            this.problemReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.problemReportButton.FlatAppearance.BorderSize = 0;
            this.problemReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemReportButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.problemReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemReportButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.problemReportButton.IconChar = FontAwesome.Sharp.IconChar.Bug;
            this.problemReportButton.IconColor = System.Drawing.Color.Gainsboro;
            this.problemReportButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.problemReportButton.IconSize = 40;
            this.problemReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.problemReportButton.Location = new System.Drawing.Point(530, 0);
            this.problemReportButton.Margin = new System.Windows.Forms.Padding(6);
            this.problemReportButton.Name = "problemReportButton";
            this.problemReportButton.Padding = new System.Windows.Forms.Padding(16, 0, 30, 0);
            this.problemReportButton.Rotation = 0D;
            this.problemReportButton.Size = new System.Drawing.Size(530, 100);
            this.problemReportButton.TabIndex = 12;
            this.problemReportButton.Text = "Report a problem";
            this.problemReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.problemReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.problemReportButton.UseVisualStyleBackColor = false;
            this.problemReportButton.Click += new System.EventHandler(this.problemReportButton_Click);
            // 
            // contributePanel
            // 
            this.contributePanel.Controls.Add(this.titleLabel);
            this.contributePanel.Controls.Add(this.buttonSendFeedBack);
            this.contributePanel.Controls.Add(this.yourOpinionLabel);
            this.contributePanel.Controls.Add(this.textBoxContent);
            this.contributePanel.Controls.Add(this.phoneNumberLabel);
            this.contributePanel.Controls.Add(this.nameLabel);
            this.contributePanel.Controls.Add(this.emailLabel);
            this.contributePanel.Controls.Add(this.textBoxName);
            this.contributePanel.Controls.Add(this.textBoxPhoneNumber);
            this.contributePanel.Controls.Add(this.textBoxEmail);
            this.contributePanel.Location = new System.Drawing.Point(0, 160);
            this.contributePanel.Name = "contributePanel";
            this.contributePanel.Size = new System.Drawing.Size(1615, 1310);
            this.contributePanel.TabIndex = 28;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.titleLabel.Location = new System.Drawing.Point(40, 40);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1107, 91);
            this.titleLabel.TabIndex = 26;
            this.titleLabel.Text = "Help us to improve our service";
            // 
            // buttonSendFeedBack
            // 
            this.buttonSendFeedBack.FlatAppearance.BorderSize = 0;
            this.buttonSendFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendFeedBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSendFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendFeedBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSendFeedBack.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.buttonSendFeedBack.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSendFeedBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSendFeedBack.IconSize = 50;
            this.buttonSendFeedBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSendFeedBack.Location = new System.Drawing.Point(1096, 1000);
            this.buttonSendFeedBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSendFeedBack.Name = "buttonSendFeedBack";
            this.buttonSendFeedBack.Padding = new System.Windows.Forms.Padding(16, 0, 30, 0);
            this.buttonSendFeedBack.Rotation = 0D;
            this.buttonSendFeedBack.Size = new System.Drawing.Size(390, 65);
            this.buttonSendFeedBack.TabIndex = 25;
            this.buttonSendFeedBack.Text = "Send Feedback";
            this.buttonSendFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSendFeedBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSendFeedBack.UseVisualStyleBackColor = true;
            this.buttonSendFeedBack.Click += new System.EventHandler(this.buttonSendFeedBack_Click);
            // 
            // yourOpinionLabel
            // 
            this.yourOpinionLabel.AutoSize = true;
            this.yourOpinionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourOpinionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourOpinionLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.yourOpinionLabel.Location = new System.Drawing.Point(140, 580);
            this.yourOpinionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yourOpinionLabel.Name = "yourOpinionLabel";
            this.yourOpinionLabel.Size = new System.Drawing.Size(253, 44);
            this.yourOpinionLabel.TabIndex = 24;
            this.yourOpinionLabel.Text = "Your opinion: ";
            this.yourOpinionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxContent
            // 
            this.textBoxContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBoxContent.BorderColor = System.Drawing.Color.Firebrick;
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxContent.Location = new System.Drawing.Point(464, 580);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(1022, 342);
            this.textBoxContent.TabIndex = 20;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.phoneNumberLabel.Location = new System.Drawing.Point(97, 476);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(296, 44);
            this.phoneNumberLabel.TabIndex = 23;
            this.phoneNumberLabel.Text = "Phone Number: ";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameLabel.Location = new System.Drawing.Point(161, 356);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(232, 44);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "Your Name: ";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.emailLabel.Location = new System.Drawing.Point(255, 234);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(138, 44);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "Email: ";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.HintForeColor = System.Drawing.Color.DimGray;
            this.textBoxName.HintText = "Name";
            this.textBoxName.isPassword = false;
            this.textBoxName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textBoxName.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textBoxName.LineThickness = 4;
            this.textBoxName.Location = new System.Drawing.Point(464, 319);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(1022, 81);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxPhoneNumber.HintForeColor = System.Drawing.Color.DimGray;
            this.textBoxPhoneNumber.HintText = "Phone Number";
            this.textBoxPhoneNumber.isPassword = false;
            this.textBoxPhoneNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textBoxPhoneNumber.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.textBoxPhoneNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textBoxPhoneNumber.LineThickness = 4;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(464, 439);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(1022, 81);
            this.textBoxPhoneNumber.TabIndex = 16;
            this.textBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxEmail.HintForeColor = System.Drawing.Color.DimGray;
            this.textBoxEmail.HintText = "Email";
            this.textBoxEmail.isPassword = false;
            this.textBoxEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textBoxEmail.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.textBoxEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textBoxEmail.LineThickness = 3;
            this.textBoxEmail.Location = new System.Drawing.Point(464, 199);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(1022, 81);
            this.textBoxEmail.TabIndex = 15;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1413);
            this.Controls.Add(this.contentPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.contentPanel.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.contributePanel.ResumeLayout(false);
            this.contributePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPhoneNumber;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textBoxContent;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label yourOpinionLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label nameLabel;
        private FontAwesome.Sharp.IconButton buttonSendFeedBack;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel tabPanel;
        private FontAwesome.Sharp.IconButton problemReportButton;
        private FontAwesome.Sharp.IconButton contributeButton;
        private System.Windows.Forms.Panel contributePanel;
    }
}