namespace Dictionary_host
{
    partial class FeedBackForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.feedBackGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.viewButton = new FontAwesome.Sharp.IconButton();
            this.btnDeleteFeedBack = new FontAwesome.Sharp.IconButton();
            this.PickAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeedBackTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // feedBackGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.feedBackGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.feedBackGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feedBackGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.feedBackGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedBackGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.feedBackGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedBackGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.feedBackGridView.ColumnHeadersHeight = 70;
            this.feedBackGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PickAll,
            this.Id,
            this.FeedBackTime,
            this.Title,
            this.FullName,
            this.Email,
            this.PhoneNumber,
            this.Content});
            this.feedBackGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.feedBackGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.feedBackGridView.DoubleBuffered = true;
            this.feedBackGridView.EnableHeadersVisualStyles = false;
            this.feedBackGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.feedBackGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.feedBackGridView.HeaderForeColor = System.Drawing.Color.FloralWhite;
            this.feedBackGridView.Location = new System.Drawing.Point(-10, 110);
            this.feedBackGridView.Name = "feedBackGridView";
            this.feedBackGridView.ReadOnly = true;
            this.feedBackGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.feedBackGridView.RowHeadersVisible = false;
            this.feedBackGridView.RowHeadersWidth = 5;
            this.feedBackGridView.RowTemplate.Height = 60;
            this.feedBackGridView.RowTemplate.ReadOnly = true;
            this.feedBackGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.feedBackGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.feedBackGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.feedBackGridView.Size = new System.Drawing.Size(1565, 730);
            this.feedBackGridView.TabIndex = 2;
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.viewButton.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.viewButton.IconColor = System.Drawing.Color.White;
            this.viewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.viewButton.IconSize = 48;
            this.viewButton.Location = new System.Drawing.Point(1024, 877);
            this.viewButton.Name = "viewButton";
            this.viewButton.Rotation = 0D;
            this.viewButton.Size = new System.Drawing.Size(198, 68);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "Read";
            this.viewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // btnDeleteFeedBack
            // 
            this.btnDeleteFeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btnDeleteFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFeedBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteFeedBack.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFeedBack.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFeedBack.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteFeedBack.IconColor = System.Drawing.Color.White;
            this.btnDeleteFeedBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteFeedBack.IconSize = 48;
            this.btnDeleteFeedBack.Location = new System.Drawing.Point(1293, 877);
            this.btnDeleteFeedBack.Name = "btnDeleteFeedBack";
            this.btnDeleteFeedBack.Rotation = 0D;
            this.btnDeleteFeedBack.Size = new System.Drawing.Size(198, 68);
            this.btnDeleteFeedBack.TabIndex = 5;
            this.btnDeleteFeedBack.Text = "Delete";
            this.btnDeleteFeedBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFeedBack.UseVisualStyleBackColor = true;
            this.btnDeleteFeedBack.Click += new System.EventHandler(this.btnDeleteFeedBack_Click);
            // 
            // PickAll
            // 
            this.PickAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PickAll.FillWeight = 228.4264F;
            this.PickAll.HeaderText = "";
            this.PickAll.Name = "PickAll";
            this.PickAll.ReadOnly = true;
            this.PickAll.Width = 75;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "fb_id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FeedBackTime
            // 
            this.FeedBackTime.DataPropertyName = "FeedBackTime";
            this.FeedBackTime.FillWeight = 74.31472F;
            this.FeedBackTime.HeaderText = "Time";
            this.FeedBackTime.Name = "FeedBackTime";
            this.FeedBackTime.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 74.31472F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 74.31472F;
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 74.31472F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PN";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.FillWeight = 74.31472F;
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // FeedBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1554, 1064);
            this.Controls.Add(this.btnDeleteFeedBack);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.feedBackGridView);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FeedBackForm";
            this.Text = "FeedBack";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FeedBackForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.feedBackGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid feedBackGridView;
        private FontAwesome.Sharp.IconButton viewButton;
        private FontAwesome.Sharp.IconButton btnDeleteFeedBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeedBackTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
    }
}