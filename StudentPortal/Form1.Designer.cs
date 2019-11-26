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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchIdText = new System.Windows.Forms.TextBox();
            this.searchIdBtn = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchIdBtn);
            this.searchPanel.Controls.Add(this.searchIdText);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Location = new System.Drawing.Point(492, 97);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(333, 341);
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
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter ID to search: ";
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
            this.uniText.TabIndex = 5;
            this.uniText.TextChanged += new System.EventHandler(this.UniText_TextChanged);
            // 
            // departmentText
            // 
            this.departmentText.Location = new System.Drawing.Point(160, 92);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(147, 20);
            this.departmentText.TabIndex = 4;
            this.departmentText.TextChanged += new System.EventHandler(this.DepartmentText_TextChanged);
            // 
            // gpaText
            // 
            this.gpaText.Location = new System.Drawing.Point(160, 66);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(147, 20);
            this.gpaText.TabIndex = 3;
            this.gpaText.TextChanged += new System.EventHandler(this.GpaText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(160, 40);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(147, 20);
            this.nameText.TabIndex = 2;
            this.nameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // enterRecord
            // 
            this.enterRecord.Location = new System.Drawing.Point(132, 155);
            this.enterRecord.Name = "enterRecord";
            this.enterRecord.Size = new System.Drawing.Size(96, 23);
            this.enterRecord.TabIndex = 6;
            this.enterRecord.Text = "Enter Student";
            this.enterRecord.UseVisualStyleBackColor = true;
            this.enterRecord.Click += new System.EventHandler(this.EnterRecord_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProfileToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.top3StudentsToolStripMenuItem,
            this.markAttendanceToolStripMenuItem,
            this.viewAttendanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createProfileToolStripMenuItem
            // 
            this.createProfileToolStripMenuItem.Name = "createProfileToolStripMenuItem";
            this.createProfileToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.createProfileToolStripMenuItem.Text = "Create Profile";
            this.createProfileToolStripMenuItem.Click += new System.EventHandler(this.CreateProfileToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByIDToolStripMenuItem,
            this.searchByNameToolStripMenuItem,
            this.listOfAllStudentsToolStripMenuItem});
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            // 
            // searchByIDToolStripMenuItem
            // 
            this.searchByIDToolStripMenuItem.Name = "searchByIDToolStripMenuItem";
            this.searchByIDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchByIDToolStripMenuItem.Text = "Search by ID";
            this.searchByIDToolStripMenuItem.Click += new System.EventHandler(this.SearchByIDToolStripMenuItem_Click);
            // 
            // searchByNameToolStripMenuItem
            // 
            this.searchByNameToolStripMenuItem.Name = "searchByNameToolStripMenuItem";
            this.searchByNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchByNameToolStripMenuItem.Text = "Search By Name";
            // 
            // listOfAllStudentsToolStripMenuItem
            // 
            this.listOfAllStudentsToolStripMenuItem.Name = "listOfAllStudentsToolStripMenuItem";
            this.listOfAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfAllStudentsToolStripMenuItem.Text = "List of All Students";
            // 
            // top3StudentsToolStripMenuItem
            // 
            this.top3StudentsToolStripMenuItem.Name = "top3StudentsToolStripMenuItem";
            this.top3StudentsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.top3StudentsToolStripMenuItem.Text = "Top 3 Students";
            // 
            // markAttendanceToolStripMenuItem
            // 
            this.markAttendanceToolStripMenuItem.Name = "markAttendanceToolStripMenuItem";
            this.markAttendanceToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.markAttendanceToolStripMenuItem.Text = "Mark Attendance";
            // 
            // viewAttendanceToolStripMenuItem
            // 
            this.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            this.viewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.viewAttendanceToolStripMenuItem.Text = "View Attendance";
            // 
            // searchIdText
            // 
            this.searchIdText.Location = new System.Drawing.Point(117, 27);
            this.searchIdText.Name = "searchIdText";
            this.searchIdText.Size = new System.Drawing.Size(147, 20);
            this.searchIdText.TabIndex = 1;
            this.searchIdText.TextChanged += new System.EventHandler(this.SearchIdText_TextChanged);
            // 
            // searchIdBtn
            // 
            this.searchIdBtn.Location = new System.Drawing.Point(117, 69);
            this.searchIdBtn.Name = "searchIdBtn";
            this.searchIdBtn.Size = new System.Drawing.Size(75, 23);
            this.searchIdBtn.TabIndex = 2;
            this.searchIdBtn.Text = "Search";
            this.searchIdBtn.UseVisualStyleBackColor = true;
            this.searchIdBtn.Click += new System.EventHandler(this.SearchIdBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label idLabel;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top3StudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendanceToolStripMenuItem;
        private System.Windows.Forms.TextBox searchIdText;
        private System.Windows.Forms.Button searchIdBtn;
    }
}

