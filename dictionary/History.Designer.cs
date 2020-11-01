namespace dictionary
{
    partial class History
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
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.labelSearch = new System.Windows.Forms.Label();
            this.Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.iconButtonSearch);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Controls.Add(this.Search);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 462);
            this.panel1.TabIndex = 1;
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 25;
            this.iconButtonSearch.Location = new System.Drawing.Point(491, 44);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Rotation = 0D;
            this.iconButtonSearch.Size = new System.Drawing.Size(41, 39);
            this.iconButtonSearch.TabIndex = 2;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSearch.Location = new System.Drawing.Point(3, 34);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(95, 30);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search";
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.Search.HintForeColor = System.Drawing.Color.Gainsboro;
            this.Search.HintText = "";
            this.Search.isPassword = false;
            this.Search.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Search.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Search.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Search.LineThickness = 3;
            this.Search.Location = new System.Drawing.Point(105, 20);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(370, 44);
            this.Search.TabIndex = 0;
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Search.OnValueChanged += new System.EventHandler(this.Search_OnValueChanged);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "History";
            this.Text = "History";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Search;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.Label labelSearch;
    }
}