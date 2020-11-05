namespace dictionary
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.illustrationImageList = new System.Windows.Forms.ImageList(this.components);
            this.meaningRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDictionary = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.textboxSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelHint2 = new System.Windows.Forms.Label();
            this.labelHint1 = new System.Windows.Forms.Label();
            this.labelHint4 = new System.Windows.Forms.Label();
            this.labelHint3 = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.typedWord = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.buttonSearch = new FontAwesome.Sharp.IconButton();
            this.pictureBoxFlagLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlagRight = new System.Windows.Forms.PictureBox();
            this.buttonSwitch = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnFeedback = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btn_Bookmark = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnHistory = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // illustrationImageList
            // 
            this.illustrationImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.illustrationImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.illustrationImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // meaningRichTextBox
            // 
            this.meaningRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.meaningRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.meaningRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaningRichTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaningRichTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.meaningRichTextBox.Location = new System.Drawing.Point(545, 384);
            this.meaningRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.meaningRichTextBox.Name = "meaningRichTextBox";
            this.meaningRichTextBox.ReadOnly = true;
            this.meaningRichTextBox.Size = new System.Drawing.Size(207, 89);
            this.meaningRichTextBox.TabIndex = 8;
            this.meaningRichTextBox.Text = "";
            this.meaningRichTextBox.Visible = false;
            this.meaningRichTextBox.TextChanged += new System.EventHandler(this.meaningRichTextBox_TextChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnFeedback);
            this.panelMenu.Controls.Add(this.btnHelp);
            this.panelMenu.Controls.Add(this.btn_Bookmark);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnHistory);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.panelMenu.Size = new System.Drawing.Size(190, 718);
            this.panelMenu.TabIndex = 10;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDictionary);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 122);
            this.panel2.TabIndex = 0;
            // 
            // labelDictionary
            // 
            this.labelDictionary.AutoSize = true;
            this.labelDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDictionary.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDictionary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(50)))));
            this.labelDictionary.Location = new System.Drawing.Point(27, 85);
            this.labelDictionary.Name = "labelDictionary";
            this.labelDictionary.Size = new System.Drawing.Size(135, 28);
            this.labelDictionary.TabIndex = 1;
            this.labelDictionary.Text = "Dictionary";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.textboxSearch);
            this.panelTitleBar.Controls.Add(this.buttonSearch);
            this.panelTitleBar.Controls.Add(this.pictureBoxFlagLeft);
            this.panelTitleBar.Controls.Add(this.pictureBoxFlagRight);
            this.panelTitleBar.Controls.Add(this.buttonSwitch);
            this.panelTitleBar.Location = new System.Drawing.Point(190, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(784, 72);
            this.panelTitleBar.TabIndex = 11;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(51, 31);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(64, 17);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Translate";
            // 
            // textboxSearch
            // 
            this.textboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.textboxSearch.HintForeColor = System.Drawing.Color.Gainsboro;
            this.textboxSearch.HintText = "Search English";
            this.textboxSearch.isPassword = false;
            this.textboxSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textboxSearch.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.textboxSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.textboxSearch.LineThickness = 2;
            this.textboxSearch.Location = new System.Drawing.Point(139, 19);
            this.textboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(422, 39);
            this.textboxSearch.TabIndex = 14;
            this.textboxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxSearch.OnValueChanged += new System.EventHandler(this.textboxSearch_OnValueChanged);
            this.textboxSearch.DoubleClick += new System.EventHandler(this.textboxSearch_DoubleClick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBoxResult);
            this.panelDesktop.Controls.Add(this.labelResult);
            this.panelDesktop.Controls.Add(this.typedWord);
            this.panelDesktop.Controls.Add(this.panel4);
            this.panelDesktop.Controls.Add(this.label13);
            this.panelDesktop.Controls.Add(this.panel3);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Controls.Add(this.labelEnglish);
            this.panelDesktop.Controls.Add(this.btnPlay);
            this.panelDesktop.Controls.Add(this.meaningRichTextBox);
            this.panelDesktop.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Location = new System.Drawing.Point(190, 68);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(784, 650);
            this.panelDesktop.TabIndex = 12;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // labelHint2
            // 
            this.labelHint2.AutoSize = true;
            this.labelHint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint2.Location = new System.Drawing.Point(16, 83);
            this.labelHint2.Name = "labelHint2";
            this.labelHint2.Size = new System.Drawing.Size(80, 22);
            this.labelHint2.TabIndex = 19;
            this.labelHint2.Text = "blessing";
            this.labelHint2.Click += new System.EventHandler(this.labelHint2_Click);
            this.labelHint2.MouseLeave += new System.EventHandler(this.labelHint2_MouseLeave);
            this.labelHint2.MouseHover += new System.EventHandler(this.labelHint2_MouseHover);
            // 
            // labelHint1
            // 
            this.labelHint1.AutoSize = true;
            this.labelHint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHint1.Location = new System.Drawing.Point(16, 43);
            this.labelHint1.Name = "labelHint1";
            this.labelHint1.Size = new System.Drawing.Size(74, 22);
            this.labelHint1.TabIndex = 18;
            this.labelHint1.Text = "admire";
            this.labelHint1.MouseLeave += new System.EventHandler(this.labelHint1_MouseLeave);
            this.labelHint1.MouseHover += new System.EventHandler(this.labelHint1_MouseHover);
            // 
            // labelHint4
            // 
            this.labelHint4.AutoSize = true;
            this.labelHint4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint4.Location = new System.Drawing.Point(16, 123);
            this.labelHint4.Name = "labelHint4";
            this.labelHint4.Size = new System.Drawing.Size(77, 22);
            this.labelHint4.TabIndex = 21;
            this.labelHint4.Text = "despair";
            this.labelHint4.MouseLeave += new System.EventHandler(this.labelHint4_MouseLeave);
            this.labelHint4.MouseHover += new System.EventHandler(this.labelHint4_MouseHover);
            // 
            // labelHint3
            // 
            this.labelHint3.AutoSize = true;
            this.labelHint3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint3.Location = new System.Drawing.Point(16, 163);
            this.labelHint3.Name = "labelHint3";
            this.labelHint3.Size = new System.Drawing.Size(131, 22);
            this.labelHint3.TabIndex = 20;
            this.labelHint3.Text = "collaboration";
            this.labelHint3.Click += new System.EventHandler(this.labelHint3_Click);
            this.labelHint3.MouseLeave += new System.EventHandler(this.labelHint3_MouseLeave);
            this.labelHint3.MouseHover += new System.EventHandler(this.labelHint3_MouseHover);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(8, 4);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(120, 24);
            this.labelHint.TabIndex = 17;
            this.labelHint.Text = "Suggestion";
            this.labelHint.Click += new System.EventHandler(this.labelHint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelHint);
            this.panel1.Controls.Add(this.labelHint3);
            this.panel1.Controls.Add(this.labelHint4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelHint1);
            this.panel1.Controls.Add(this.labelHint2);
            this.panel1.Location = new System.Drawing.Point(5, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 193);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Recently history";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(259, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 192);
            this.panel3.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "collaboration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "despair";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(16, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "admire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "blessing";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(508, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 192);
            this.panel4.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "collaboration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "despair";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(16, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "admire";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "Recently bookmark";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "blessing";
            // 
            // typedWord
            // 
            this.typedWord.AutoSize = true;
            this.typedWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typedWord.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typedWord.Location = new System.Drawing.Point(37, 282);
            this.typedWord.Name = "typedWord";
            this.typedWord.Size = new System.Drawing.Size(114, 22);
            this.typedWord.TabIndex = 30;
            this.typedWord.Text = "typedWord";
            this.typedWord.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelResult.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(13, 245);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(140, 24);
            this.labelResult.TabIndex = 31;
            this.labelResult.Text = "Search result";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.ErrorImage = global::dictionary.Properties.Resources.examination;
            this.pictureBoxResult.Image = global::dictionary.Properties.Resources.analysis;
            this.pictureBoxResult.Location = new System.Drawing.Point(159, 239);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 32;
            this.pictureBoxResult.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Image = global::dictionary.Properties.Resources.united_kingdom;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(430, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 28;
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Image = global::dictionary.Properties.Resources.united_kingdom;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(424, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 26;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dictionary.Properties.Resources.idea;
            this.pictureBox1.Location = new System.Drawing.Point(125, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEnglish.Image = global::dictionary.Properties.Resources.united_kingdom;
            this.labelEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEnglish.Location = new System.Drawing.Point(151, 40);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(0, 13);
            this.labelEnglish.TabIndex = 11;
            this.labelEnglish.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.btnPlay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 35;
            this.btnPlay.Location = new System.Drawing.Point(206, 279);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0D;
            this.btnPlay.Size = new System.Drawing.Size(43, 33);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 35;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(39, 35);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearch.IconSize = 30;
            this.buttonSearch.Location = new System.Drawing.Point(559, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Rotation = 0D;
            this.buttonSearch.Size = new System.Drawing.Size(39, 38);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pictureBoxFlagLeft
            // 
            this.pictureBoxFlagLeft.Image = global::dictionary.Properties.Resources.united_kingdom;
            this.pictureBoxFlagLeft.Location = new System.Drawing.Point(625, 23);
            this.pictureBoxFlagLeft.Name = "pictureBoxFlagLeft";
            this.pictureBoxFlagLeft.Size = new System.Drawing.Size(46, 32);
            this.pictureBoxFlagLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagLeft.TabIndex = 12;
            this.pictureBoxFlagLeft.TabStop = false;
            // 
            // pictureBoxFlagRight
            // 
            this.pictureBoxFlagRight.Image = global::dictionary.Properties.Resources.vietnam;
            this.pictureBoxFlagRight.Location = new System.Drawing.Point(667, 23);
            this.pictureBoxFlagRight.Name = "pictureBoxFlagRight";
            this.pictureBoxFlagRight.Size = new System.Drawing.Size(49, 32);
            this.pictureBoxFlagRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagRight.TabIndex = 13;
            this.pictureBoxFlagRight.TabStop = false;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonSwitch.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.buttonSwitch.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSwitch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSwitch.IconSize = 25;
            this.buttonSwitch.Location = new System.Drawing.Point(722, 24);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Rotation = 0D;
            this.buttonSwitch.Size = new System.Drawing.Size(37, 31);
            this.buttonSwitch.TabIndex = 16;
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(6, 124);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(182, 34);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Translate";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFeedback.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFeedback.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            this.btnFeedback.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFeedback.IconSize = 32;
            this.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.Location = new System.Drawing.Point(8, 324);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnFeedback.Rotation = 0D;
            this.btnFeedback.Size = new System.Drawing.Size(182, 34);
            this.btnFeedback.TabIndex = 17;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnHelp.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 32;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(6, 284);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnHelp.Rotation = 0D;
            this.btnHelp.Size = new System.Drawing.Size(182, 34);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help ";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btn_Bookmark
            // 
            this.btn_Bookmark.FlatAppearance.BorderSize = 0;
            this.btn_Bookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bookmark.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Bookmark.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bookmark.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Bookmark.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btn_Bookmark.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Bookmark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Bookmark.IconSize = 32;
            this.btn_Bookmark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bookmark.Location = new System.Drawing.Point(6, 204);
            this.btn_Bookmark.Name = "btn_Bookmark";
            this.btn_Bookmark.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btn_Bookmark.Rotation = 0D;
            this.btn_Bookmark.Size = new System.Drawing.Size(182, 34);
            this.btn_Bookmark.TabIndex = 16;
            this.btn_Bookmark.Text = "Bookmark";
            this.btn_Bookmark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bookmark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bookmark.UseVisualStyleBackColor = true;
            this.btn_Bookmark.Click += new System.EventHandler(this.btn_Bookmark_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(8, 244);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnSettings.Rotation = 0D;
            this.btnSettings.Size = new System.Drawing.Size(182, 34);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistory.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistory.IconSize = 32;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(6, 164);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnHistory.Rotation = 0D;
            this.btnHistory.Size = new System.Drawing.Size(182, 34);
            this.btnHistory.TabIndex = 12;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::dictionary.Properties.Resources.languages;
            this.btnHome.Location = new System.Drawing.Point(32, 16);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 66);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(970, 721);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dictionary";
            this.TransparencyKey = System.Drawing.Color.DarkSlateBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList illustrationImageList;
        private System.Windows.Forms.RichTextBox meaningRichTextBox;
        private System.Windows.Forms.ComboBox suggestedWordComboBox;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btn_Bookmark;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnHistory;
        private FontAwesome.Sharp.IconButton btnFeedback;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBoxFlagRight;
        private System.Windows.Forms.PictureBox pictureBoxFlagLeft;
        private FontAwesome.Sharp.IconButton buttonSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxSearch;
        private FontAwesome.Sharp.IconButton buttonSwitch;
        private System.Windows.Forms.Label labelDictionary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelHint3;
        private System.Windows.Forms.Label labelHint4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHint1;
        private System.Windows.Forms.Label labelHint2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label typedWord;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxResult;
    }
}

