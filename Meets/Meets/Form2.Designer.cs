namespace Meets
{
    partial class AddMeetingForm
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
            this.ParticipantAddBtn = new System.Windows.Forms.Button();
            this.ParticipantTxtBox = new System.Windows.Forms.TextBox();
            this.listViewParticipants = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.EndingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ParticipantAddBtn);
            this.panel1.Controls.Add(this.ParticipantTxtBox);
            this.panel1.Controls.Add(this.listViewParticipants);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EndingDatePicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StartDatePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DescTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameTxtBox);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 321);
            this.panel1.TabIndex = 0;
            // 
            // ParticipantAddBtn
            // 
            this.ParticipantAddBtn.Enabled = false;
            this.ParticipantAddBtn.Location = new System.Drawing.Point(601, 267);
            this.ParticipantAddBtn.Name = "ParticipantAddBtn";
            this.ParticipantAddBtn.Size = new System.Drawing.Size(45, 23);
            this.ParticipantAddBtn.TabIndex = 15;
            this.ParticipantAddBtn.Text = "Add";
            this.ParticipantAddBtn.UseVisualStyleBackColor = true;
            this.ParticipantAddBtn.Click += new System.EventHandler(this.ParticipantAddBtn_Click);
            // 
            // ParticipantTxtBox
            // 
            this.ParticipantTxtBox.Location = new System.Drawing.Point(390, 271);
            this.ParticipantTxtBox.Name = "ParticipantTxtBox";
            this.ParticipantTxtBox.Size = new System.Drawing.Size(204, 20);
            this.ParticipantTxtBox.TabIndex = 14;
            this.ParticipantTxtBox.TextChanged += new System.EventHandler(this.ParticipantTxtBox_TextChanged);
            // 
            // listViewParticipants
            // 
            this.listViewParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol});
            this.listViewParticipants.HideSelection = false;
            this.listViewParticipants.Location = new System.Drawing.Point(390, 160);
            this.listViewParticipants.Name = "listViewParticipants";
            this.listViewParticipants.Size = new System.Drawing.Size(256, 104);
            this.listViewParticipants.TabIndex = 13;
            this.listViewParticipants.UseCompatibleStateImageBehavior = false;
            this.listViewParticipants.View = System.Windows.Forms.View.Details;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 251;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(385, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Participants";
            // 
            // EndingDatePicker
            // 
            this.EndingDatePicker.CustomFormat = "\"yyyy/MM/dd hh:mm:ss\"";
            this.EndingDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndingDatePicker.Location = new System.Drawing.Point(390, 98);
            this.EndingDatePicker.Name = "EndingDatePicker";
            this.EndingDatePicker.Size = new System.Drawing.Size(256, 20);
            this.EndingDatePicker.TabIndex = 11;
            this.EndingDatePicker.Value = new System.DateTime(2023, 12, 6, 12, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(385, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ending Date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CustomFormat = "\"yyyy/MM/dd hh:mm:ss\"";
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(390, 47);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(256, 20);
            this.StartDatePicker.TabIndex = 9;
            this.StartDatePicker.Value = new System.DateTime(2023, 12, 6, 12, 0, 0, 0);
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(385, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Starting Date";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "InPerson",
            "Online"});
            this.comboBoxType.Location = new System.Drawing.Point(195, 270);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(116, 21);
            this.comboBoxType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(190, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Sales",
            "Dev",
            "Management"});
            this.comboBoxCategory.Location = new System.Drawing.Point(26, 270);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // DescTxtBox
            // 
            this.DescTxtBox.Location = new System.Drawing.Point(26, 111);
            this.DescTxtBox.Multiline = true;
            this.DescTxtBox.Name = "DescTxtBox";
            this.DescTxtBox.Size = new System.Drawing.Size(285, 100);
            this.DescTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(26, 48);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(285, 20);
            this.NameTxtBox.TabIndex = 1;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLbl.Location = new System.Drawing.Point(21, 19);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(71, 26);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(3, 11);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(122, 41);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(131, 11);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(122, 41);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OKButton);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Location = new System.Drawing.Point(439, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 55);
            this.panel2.TabIndex = 3;
            // 
            // AddMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(708, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMeetingForm";
            this.Text = "Add Meeting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DescTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EndingDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ParticipantAddBtn;
        private System.Windows.Forms.TextBox ParticipantTxtBox;
        private System.Windows.Forms.ListView listViewParticipants;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel panel2;
    }
}