namespace Meets
{
    partial class Form1
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
            this.NextMeetingLbl = new System.Windows.Forms.Label();
            this.MeetingNameLbl = new System.Windows.Forms.Label();
            this.MeetingDateLbl = new System.Windows.Forms.Label();
            this.MeetingTypeLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.listViewMeets = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RespPersonCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LengthCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NextMeetingLbl
            // 
            this.NextMeetingLbl.AutoSize = true;
            this.NextMeetingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMeetingLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.NextMeetingLbl.Location = new System.Drawing.Point(12, 9);
            this.NextMeetingLbl.Name = "NextMeetingLbl";
            this.NextMeetingLbl.Size = new System.Drawing.Size(247, 31);
            this.NextMeetingLbl.TabIndex = 1;
            this.NextMeetingLbl.Text = "Upcoming Meeting:";
            // 
            // MeetingNameLbl
            // 
            this.MeetingNameLbl.AutoSize = true;
            this.MeetingNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingNameLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.MeetingNameLbl.Location = new System.Drawing.Point(12, 51);
            this.MeetingNameLbl.Name = "MeetingNameLbl";
            this.MeetingNameLbl.Size = new System.Drawing.Size(182, 31);
            this.MeetingNameLbl.TabIndex = 2;
            this.MeetingNameLbl.Text = "MeetingName";
            // 
            // MeetingDateLbl
            // 
            this.MeetingDateLbl.AutoSize = true;
            this.MeetingDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingDateLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.MeetingDateLbl.Location = new System.Drawing.Point(267, 51);
            this.MeetingDateLbl.Name = "MeetingDateLbl";
            this.MeetingDateLbl.Size = new System.Drawing.Size(168, 31);
            this.MeetingDateLbl.TabIndex = 3;
            this.MeetingDateLbl.Text = "MeetingDate";
            // 
            // MeetingTypeLbl
            // 
            this.MeetingTypeLbl.AutoSize = true;
            this.MeetingTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingTypeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.MeetingTypeLbl.Location = new System.Drawing.Point(602, 51);
            this.MeetingTypeLbl.Name = "MeetingTypeLbl";
            this.MeetingTypeLbl.Size = new System.Drawing.Size(171, 31);
            this.MeetingTypeLbl.TabIndex = 4;
            this.MeetingTypeLbl.Text = "MeetingType";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(18, 415);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(135, 42);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add Meeting";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(159, 415);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(135, 42);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete Meeting";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // listViewMeets
            // 
            this.listViewMeets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.RespPersonCol,
            this.CategoryCol,
            this.TypeCol,
            this.StartDateCol,
            this.LengthCol});
            this.listViewMeets.FullRowSelect = true;
            this.listViewMeets.HideSelection = false;
            this.listViewMeets.Location = new System.Drawing.Point(12, 103);
            this.listViewMeets.Name = "listViewMeets";
            this.listViewMeets.Size = new System.Drawing.Size(761, 292);
            this.listViewMeets.TabIndex = 8;
            this.listViewMeets.UseCompatibleStateImageBehavior = false;
            this.listViewMeets.View = System.Windows.Forms.View.Details;
            this.listViewMeets.ItemActivate += new System.EventHandler(this.listViewMeets_ItemActivate);
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 143;
            // 
            // RespPersonCol
            // 
            this.RespPersonCol.Text = "Responsible Person";
            this.RespPersonCol.Width = 106;
            // 
            // CategoryCol
            // 
            this.CategoryCol.Text = "Category";
            this.CategoryCol.Width = 102;
            // 
            // TypeCol
            // 
            this.TypeCol.Text = "Type";
            this.TypeCol.Width = 83;
            // 
            // StartDateCol
            // 
            this.StartDateCol.Text = "Date";
            this.StartDateCol.Width = 127;
            // 
            // LengthCol
            // 
            this.LengthCol.Text = "Length";
            this.LengthCol.Width = 53;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(716, 415);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(57, 42);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(516, 415);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 42);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.listViewMeets);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MeetingTypeLbl);
            this.Controls.Add(this.MeetingDateLbl);
            this.Controls.Add(this.MeetingNameLbl);
            this.Controls.Add(this.NextMeetingLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NextMeetingLbl;
        private System.Windows.Forms.Label MeetingNameLbl;
        private System.Windows.Forms.Label MeetingDateLbl;
        private System.Windows.Forms.Label MeetingTypeLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ListView listViewMeets;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader RespPersonCol;
        private System.Windows.Forms.ColumnHeader CategoryCol;
        private System.Windows.Forms.ColumnHeader TypeCol;
        private System.Windows.Forms.ColumnHeader StartDateCol;
        private System.Windows.Forms.ColumnHeader LengthCol;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

