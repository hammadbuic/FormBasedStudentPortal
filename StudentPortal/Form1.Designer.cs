namespace StudentPortal
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
            this.studentProfileBtn = new System.Windows.Forms.Button();
            this.searchStudentBtn = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.topThreeBtn = new System.Windows.Forms.Button();
            this.markAttenBtn = new System.Windows.Forms.Button();
            this.viewAttenBtn = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.uniLabel = new System.Windows.Forms.Label();
            this.uniText = new System.Windows.Forms.TextBox();
            this.departmentText = new System.Windows.Forms.TextBox();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.enterRecord = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentProfileBtn
            // 
            this.studentProfileBtn.BackColor = System.Drawing.Color.Gray;
            this.studentProfileBtn.Location = new System.Drawing.Point(0, 3);
            this.studentProfileBtn.Name = "studentProfileBtn";
            this.studentProfileBtn.Size = new System.Drawing.Size(129, 33);
            this.studentProfileBtn.TabIndex = 0;
            this.studentProfileBtn.Text = "Create Profile";
            this.studentProfileBtn.UseVisualStyleBackColor = false;
            this.studentProfileBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // searchStudentBtn
            // 
            this.searchStudentBtn.BackColor = System.Drawing.Color.Gray;
            this.searchStudentBtn.Location = new System.Drawing.Point(124, 3);
            this.searchStudentBtn.Name = "searchStudentBtn";
            this.searchStudentBtn.Size = new System.Drawing.Size(129, 33);
            this.searchStudentBtn.TabIndex = 1;
            this.searchStudentBtn.Text = "Search Student";
            this.searchStudentBtn.UseVisualStyleBackColor = false;
            this.searchStudentBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Location = new System.Drawing.Point(492, 282);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(200, 100);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Visible = false;
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.enterRecord);
            this.profilePanel.Controls.Add(this.nameText);
            this.profilePanel.Controls.Add(this.gpaText);
            this.profilePanel.Controls.Add(this.departmentText);
            this.profilePanel.Controls.Add(this.uniText);
            this.profilePanel.Controls.Add(this.uniLabel);
            this.profilePanel.Controls.Add(this.departmentLabel);
            this.profilePanel.Controls.Add(this.gpaLabel);
            this.profilePanel.Controls.Add(this.nameLabel);
            this.profilePanel.Controls.Add(this.idText);
            this.profilePanel.Controls.Add(this.idLabel);
            this.profilePanel.Location = new System.Drawing.Point(12, 97);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(418, 341);
            this.profilePanel.TabIndex = 3;
            this.profilePanel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(89, 17);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(62, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Student Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.viewAttenBtn);
            this.panel3.Controls.Add(this.markAttenBtn);
            this.panel3.Controls.Add(this.topThreeBtn);
            this.panel3.Controls.Add(this.deleteStudentBtn);
            this.panel3.Controls.Add(this.studentProfileBtn);
            this.panel3.Controls.Add(this.searchStudentBtn);
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(856, 39);
            this.panel3.TabIndex = 4;
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.BackColor = System.Drawing.Color.Gray;
            this.deleteStudentBtn.Location = new System.Drawing.Point(248, 3);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(129, 33);
            this.deleteStudentBtn.TabIndex = 2;
            this.deleteStudentBtn.Text = "Delete Record";
            this.deleteStudentBtn.UseVisualStyleBackColor = false;
            // 
            // topThreeBtn
            // 
            this.topThreeBtn.BackColor = System.Drawing.Color.Gray;
            this.topThreeBtn.Location = new System.Drawing.Point(383, 3);
            this.topThreeBtn.Name = "topThreeBtn";
            this.topThreeBtn.Size = new System.Drawing.Size(129, 33);
            this.topThreeBtn.TabIndex = 3;
            this.topThreeBtn.Text = "Top 3";
            this.topThreeBtn.UseVisualStyleBackColor = false;
            // 
            // markAttenBtn
            // 
            this.markAttenBtn.BackColor = System.Drawing.Color.Gray;
            this.markAttenBtn.Location = new System.Drawing.Point(507, 3);
            this.markAttenBtn.Name = "markAttenBtn";
            this.markAttenBtn.Size = new System.Drawing.Size(129, 33);
            this.markAttenBtn.TabIndex = 4;
            this.markAttenBtn.Text = "Attendance Mark";
            this.markAttenBtn.UseVisualStyleBackColor = false;
            // 
            // viewAttenBtn
            // 
            this.viewAttenBtn.BackColor = System.Drawing.Color.Gray;
            this.viewAttenBtn.Location = new System.Drawing.Point(637, 3);
            this.viewAttenBtn.Name = "viewAttenBtn";
            this.viewAttenBtn.Size = new System.Drawing.Size(129, 33);
            this.viewAttenBtn.TabIndex = 5;
            this.viewAttenBtn.Text = "View Attendance";
            this.viewAttenBtn.UseVisualStyleBackColor = false;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(160, 14);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(147, 20);
            this.idText.TabIndex = 1;
            this.idText.TextChanged += new System.EventHandler(this.IdText_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Student Name: ";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(69, 69);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(82, 13);
            this.gpaLabel.TabIndex = 3;
            this.gpaLabel.Text = "Student CGPA: ";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(46, 95);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(108, 13);
            this.departmentLabel.TabIndex = 4;
            this.departmentLabel.Text = "Student Department: ";
            // 
            // uniLabel
            // 
            this.uniLabel.AutoSize = true;
            this.uniLabel.Location = new System.Drawing.Point(55, 121);
            this.uniLabel.Name = "uniLabel";
            this.uniLabel.Size = new System.Drawing.Size(99, 13);
            this.uniLabel.TabIndex = 5;
            this.uniLabel.Text = "Student University: ";
            // 
            // uniText
            // 
            this.uniText.Location = new System.Drawing.Point(160, 118);
            this.uniText.Name = "uniText";
            this.uniText.Size = new System.Drawing.Size(147, 20);
            this.uniText.TabIndex = 7;
            this.uniText.TextChanged += new System.EventHandler(this.UniText_TextChanged);
            // 
            // departmentText
            // 
            this.departmentText.Location = new System.Drawing.Point(160, 92);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(147, 20);
            this.departmentText.TabIndex = 8;
            this.departmentText.TextChanged += new System.EventHandler(this.DepartmentText_TextChanged);
            // 
            // gpaText
            // 
            this.gpaText.Location = new System.Drawing.Point(160, 66);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(147, 20);
            this.gpaText.TabIndex = 9;
            this.gpaText.TextChanged += new System.EventHandler(this.GpaText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(160, 40);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(147, 20);
            this.nameText.TabIndex = 10;
            this.nameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // enterRecord
            // 
            this.enterRecord.Location = new System.Drawing.Point(132, 155);
            this.enterRecord.Name = "enterRecord";
            this.enterRecord.Size = new System.Drawing.Size(96, 23);
            this.enterRecord.TabIndex = 11;
            this.enterRecord.Text = "Enter Student";
            this.enterRecord.UseVisualStyleBackColor = true;
            this.enterRecord.Click += new System.EventHandler(this.EnterRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.searchPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentProfileBtn;
        private System.Windows.Forms.Button searchStudentBtn;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button topThreeBtn;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.Button viewAttenBtn;
        private System.Windows.Forms.Button markAttenBtn;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox gpaText;
        private System.Windows.Forms.TextBox departmentText;
        private System.Windows.Forms.TextBox uniText;
        private System.Windows.Forms.Label uniLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button enterRecord;
    }
}

