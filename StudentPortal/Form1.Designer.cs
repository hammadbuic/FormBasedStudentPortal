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
            this.idSearchGrid = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchIdBtn = new System.Windows.Forms.Button();
            this.searchIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.enterRecord = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.departmentText = new System.Windows.Forms.TextBox();
            this.uniText = new System.Windows.Forms.TextBox();
            this.uniLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameSearchPanel = new System.Windows.Forms.Panel();
            this.searchNameGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seachNameBtn = new System.Windows.Forms.Button();
            this.searchNameText = new System.Windows.Forms.TextBox();
            this.nameSeachLabel = new System.Windows.Forms.Label();
            this.allStudentPanel = new System.Windows.Forms.Panel();
            this.allStudentGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allStudentLabel = new System.Windows.Forms.Label();
            this.topThreePanel = new System.Windows.Forms.Panel();
            this.topThreeGrid = new System.Windows.Forms.DataGridView();
            this.topThreeLabel = new System.Windows.Forms.Label();
            this.markAttenPanel = new System.Windows.Forms.Panel();
            this.markAttenLabel = new System.Windows.Forms.Label();
            this.markAttenGrid = new System.Windows.Forms.DataGridView();
            this.viewAttenPanel = new System.Windows.Forms.Panel();
            this.viewAttenGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAttenLabel = new System.Windows.Forms.Label();
            this.deleteStuPanel = new System.Windows.Forms.Panel();
            this.deleteStuBtn = new System.Windows.Forms.Button();
            this.deleteStuText = new System.Windows.Forms.TextBox();
            this.DeleteStuLabel = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSearchGrid)).BeginInit();
            this.profilePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.nameSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchNameGrid)).BeginInit();
            this.allStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentGrid)).BeginInit();
            this.topThreePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topThreeGrid)).BeginInit();
            this.markAttenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markAttenGrid)).BeginInit();
            this.viewAttenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAttenGrid)).BeginInit();
            this.deleteStuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.idSearchGrid);
            this.searchPanel.Controls.Add(this.searchIdBtn);
            this.searchPanel.Controls.Add(this.searchIdText);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Location = new System.Drawing.Point(12, 100);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(475, 341);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Visible = false;
            // 
            // idSearchGrid
            // 
            this.idSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.nameCol,
            this.gpaCol,
            this.departCol,
            this.uniCol});
            this.idSearchGrid.Location = new System.Drawing.Point(15, 98);
            this.idSearchGrid.Name = "idSearchGrid";
            this.idSearchGrid.Size = new System.Drawing.Size(448, 150);
            this.idSearchGrid.TabIndex = 3;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            // 
            // gpaCol
            // 
            this.gpaCol.HeaderText = "CGPA";
            this.gpaCol.Name = "gpaCol";
            // 
            // departCol
            // 
            this.departCol.HeaderText = "Department";
            this.departCol.Name = "departCol";
            // 
            // uniCol
            // 
            this.uniCol.HeaderText = "University";
            this.uniCol.Name = "uniCol";
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
            // searchIdText
            // 
            this.searchIdText.Location = new System.Drawing.Point(117, 27);
            this.searchIdText.Name = "searchIdText";
            this.searchIdText.Size = new System.Drawing.Size(147, 20);
            this.searchIdText.TabIndex = 1;
            this.searchIdText.TextChanged += new System.EventHandler(this.SearchIdText_TextChanged);
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
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(160, 40);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(147, 20);
            this.nameText.TabIndex = 2;
            this.nameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // gpaText
            // 
            this.gpaText.Location = new System.Drawing.Point(160, 66);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(147, 20);
            this.gpaText.TabIndex = 3;
            this.gpaText.TextChanged += new System.EventHandler(this.GpaText_TextChanged);
            // 
            // departmentText
            // 
            this.departmentText.Location = new System.Drawing.Point(160, 92);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(147, 20);
            this.departmentText.TabIndex = 4;
            this.departmentText.TextChanged += new System.EventHandler(this.DepartmentText_TextChanged);
            // 
            // uniText
            // 
            this.uniText.Location = new System.Drawing.Point(160, 118);
            this.uniText.Name = "uniText";
            this.uniText.Size = new System.Drawing.Size(147, 20);
            this.uniText.TabIndex = 5;
            this.uniText.TextChanged += new System.EventHandler(this.UniText_TextChanged);
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
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(46, 95);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(108, 13);
            this.departmentLabel.TabIndex = 4;
            this.departmentLabel.Text = "Student Department: ";
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Student Name: ";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(160, 14);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(147, 20);
            this.idText.TabIndex = 1;
            this.idText.TextChanged += new System.EventHandler(this.IdText_TextChanged);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProfileToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.top3StudentsToolStripMenuItem,
            this.markAttendanceToolStripMenuItem,
            this.viewAttendanceToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
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
            this.searchByIDToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.searchByIDToolStripMenuItem.Text = "Search by ID";
            this.searchByIDToolStripMenuItem.Click += new System.EventHandler(this.SearchByIDToolStripMenuItem_Click);
            // 
            // searchByNameToolStripMenuItem
            // 
            this.searchByNameToolStripMenuItem.Name = "searchByNameToolStripMenuItem";
            this.searchByNameToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.searchByNameToolStripMenuItem.Text = "Search By Name";
            this.searchByNameToolStripMenuItem.Click += new System.EventHandler(this.SearchByNameToolStripMenuItem_Click);
            // 
            // listOfAllStudentsToolStripMenuItem
            // 
            this.listOfAllStudentsToolStripMenuItem.Name = "listOfAllStudentsToolStripMenuItem";
            this.listOfAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listOfAllStudentsToolStripMenuItem.Text = "List of All Students";
            this.listOfAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.ListOfAllStudentsToolStripMenuItem_Click);
            // 
            // top3StudentsToolStripMenuItem
            // 
            this.top3StudentsToolStripMenuItem.Name = "top3StudentsToolStripMenuItem";
            this.top3StudentsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.top3StudentsToolStripMenuItem.Text = "Top 3 Students";
            this.top3StudentsToolStripMenuItem.Click += new System.EventHandler(this.Top3StudentsToolStripMenuItem_Click);
            // 
            // markAttendanceToolStripMenuItem
            // 
            this.markAttendanceToolStripMenuItem.Name = "markAttendanceToolStripMenuItem";
            this.markAttendanceToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.markAttendanceToolStripMenuItem.Text = "Mark Attendance";
            this.markAttendanceToolStripMenuItem.Click += new System.EventHandler(this.MarkAttendanceToolStripMenuItem_Click);
            // 
            // viewAttendanceToolStripMenuItem
            // 
            this.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            this.viewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.viewAttendanceToolStripMenuItem.Text = "View Attendance";
            this.viewAttendanceToolStripMenuItem.Click += new System.EventHandler(this.ViewAttendanceToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.DeleteRecordToolStripMenuItem_Click);
            // 
            // nameSearchPanel
            // 
            this.nameSearchPanel.Controls.Add(this.searchNameGrid);
            this.nameSearchPanel.Controls.Add(this.seachNameBtn);
            this.nameSearchPanel.Controls.Add(this.searchNameText);
            this.nameSearchPanel.Controls.Add(this.nameSeachLabel);
            this.nameSearchPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameSearchPanel.Location = new System.Drawing.Point(12, 100);
            this.nameSearchPanel.Name = "nameSearchPanel";
            this.nameSearchPanel.Size = new System.Drawing.Size(467, 325);
            this.nameSearchPanel.TabIndex = 6;
            this.nameSearchPanel.Visible = false;
            // 
            // searchNameGrid
            // 
            this.searchNameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchNameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.searchNameGrid.Location = new System.Drawing.Point(12, 118);
            this.searchNameGrid.Name = "searchNameGrid";
            this.searchNameGrid.Size = new System.Drawing.Size(448, 150);
            this.searchNameGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CGPA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Department";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "University";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // seachNameBtn
            // 
            this.seachNameBtn.Location = new System.Drawing.Point(166, 68);
            this.seachNameBtn.Name = "seachNameBtn";
            this.seachNameBtn.Size = new System.Drawing.Size(75, 23);
            this.seachNameBtn.TabIndex = 2;
            this.seachNameBtn.Text = "Search";
            this.seachNameBtn.UseVisualStyleBackColor = true;
            this.seachNameBtn.Click += new System.EventHandler(this.SeachNameBtn_Click);
            // 
            // searchNameText
            // 
            this.searchNameText.Location = new System.Drawing.Point(166, 40);
            this.searchNameText.Name = "searchNameText";
            this.searchNameText.Size = new System.Drawing.Size(147, 20);
            this.searchNameText.TabIndex = 1;
            this.searchNameText.TextChanged += new System.EventHandler(this.SeachNameText_TextChanged);
            // 
            // nameSeachLabel
            // 
            this.nameSeachLabel.AutoSize = true;
            this.nameSeachLabel.Location = new System.Drawing.Point(39, 43);
            this.nameSeachLabel.Name = "nameSeachLabel";
            this.nameSeachLabel.Size = new System.Drawing.Size(121, 13);
            this.nameSeachLabel.TabIndex = 0;
            this.nameSeachLabel.Text = "Enter Name to Search:  ";
            // 
            // allStudentPanel
            // 
            this.allStudentPanel.Controls.Add(this.allStudentGrid);
            this.allStudentPanel.Controls.Add(this.allStudentLabel);
            this.allStudentPanel.Location = new System.Drawing.Point(12, 100);
            this.allStudentPanel.Name = "allStudentPanel";
            this.allStudentPanel.Size = new System.Drawing.Size(467, 325);
            this.allStudentPanel.TabIndex = 7;
            this.allStudentPanel.Visible = false;
            // 
            // allStudentGrid
            // 
            this.allStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allStudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.allStudentGrid.Location = new System.Drawing.Point(7, 92);
            this.allStudentGrid.Name = "allStudentGrid";
            this.allStudentGrid.Size = new System.Drawing.Size(448, 150);
            this.allStudentGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "CGPA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Department";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "University";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // allStudentLabel
            // 
            this.allStudentLabel.AutoSize = true;
            this.allStudentLabel.Location = new System.Drawing.Point(88, 31);
            this.allStudentLabel.Name = "allStudentLabel";
            this.allStudentLabel.Size = new System.Drawing.Size(94, 13);
            this.allStudentLabel.TabIndex = 0;
            this.allStudentLabel.Text = "List of All Students";
            // 
            // topThreePanel
            // 
            this.topThreePanel.Controls.Add(this.topThreeGrid);
            this.topThreePanel.Controls.Add(this.topThreeLabel);
            this.topThreePanel.Location = new System.Drawing.Point(12, 94);
            this.topThreePanel.Name = "topThreePanel";
            this.topThreePanel.Size = new System.Drawing.Size(455, 328);
            this.topThreePanel.TabIndex = 8;
            this.topThreePanel.Visible = false;
            // 
            // topThreeGrid
            // 
            this.topThreeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topThreeGrid.Location = new System.Drawing.Point(10, 72);
            this.topThreeGrid.Name = "topThreeGrid";
            this.topThreeGrid.Size = new System.Drawing.Size(442, 125);
            this.topThreeGrid.TabIndex = 1;
            // 
            // topThreeLabel
            // 
            this.topThreeLabel.AutoSize = true;
            this.topThreeLabel.Location = new System.Drawing.Point(148, 20);
            this.topThreeLabel.Name = "topThreeLabel";
            this.topThreeLabel.Size = new System.Drawing.Size(102, 13);
            this.topThreeLabel.TabIndex = 0;
            this.topThreeLabel.Text = "Top Three Students";
            // 
            // markAttenPanel
            // 
            this.markAttenPanel.Controls.Add(this.markAttenLabel);
            this.markAttenPanel.Controls.Add(this.markAttenGrid);
            this.markAttenPanel.Location = new System.Drawing.Point(24, 91);
            this.markAttenPanel.Name = "markAttenPanel";
            this.markAttenPanel.Size = new System.Drawing.Size(441, 344);
            this.markAttenPanel.TabIndex = 9;
            this.markAttenPanel.Visible = false;
            // 
            // markAttenLabel
            // 
            this.markAttenLabel.AutoSize = true;
            this.markAttenLabel.Location = new System.Drawing.Point(122, 69);
            this.markAttenLabel.Name = "markAttenLabel";
            this.markAttenLabel.Size = new System.Drawing.Size(148, 13);
            this.markAttenLabel.TabIndex = 1;
            this.markAttenLabel.Text = "Mark Attendance Of Students";
            // 
            // markAttenGrid
            // 
            this.markAttenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markAttenGrid.Location = new System.Drawing.Point(3, 111);
            this.markAttenGrid.Name = "markAttenGrid";
            this.markAttenGrid.Size = new System.Drawing.Size(435, 150);
            this.markAttenGrid.TabIndex = 0;
            this.markAttenGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MarkAttenGrid_CellClick);
            // 
            // viewAttenPanel
            // 
            this.viewAttenPanel.Controls.Add(this.viewAttenGrid);
            this.viewAttenPanel.Controls.Add(this.viewAttenLabel);
            this.viewAttenPanel.Location = new System.Drawing.Point(35, 91);
            this.viewAttenPanel.Name = "viewAttenPanel";
            this.viewAttenPanel.Size = new System.Drawing.Size(427, 344);
            this.viewAttenPanel.TabIndex = 10;
            this.viewAttenPanel.Visible = false;
            // 
            // viewAttenGrid
            // 
            this.viewAttenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAttenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.Attendance});
            this.viewAttenGrid.Location = new System.Drawing.Point(3, 95);
            this.viewAttenGrid.Name = "viewAttenGrid";
            this.viewAttenGrid.Size = new System.Drawing.Size(421, 150);
            this.viewAttenGrid.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Student ID";
            this.id.Name = "id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Student Name";
            this.Name.Name = "Name";
            // 
            // Attendance
            // 
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // viewAttenLabel
            // 
            this.viewAttenLabel.AutoSize = true;
            this.viewAttenLabel.Location = new System.Drawing.Point(56, 45);
            this.viewAttenLabel.Name = "viewAttenLabel";
            this.viewAttenLabel.Size = new System.Drawing.Size(88, 13);
            this.viewAttenLabel.TabIndex = 0;
            this.viewAttenLabel.Text = "View Attendance";
            // 
            // deleteStuPanel
            // 
            this.deleteStuPanel.Controls.Add(this.deleteStuBtn);
            this.deleteStuPanel.Controls.Add(this.deleteStuText);
            this.deleteStuPanel.Controls.Add(this.DeleteStuLabel);
            this.deleteStuPanel.Location = new System.Drawing.Point(493, 82);
            this.deleteStuPanel.Name = "deleteStuPanel";
            this.deleteStuPanel.Size = new System.Drawing.Size(404, 340);
            this.deleteStuPanel.TabIndex = 11;
            this.deleteStuPanel.Visible = false;
            // 
            // deleteStuBtn
            // 
            this.deleteStuBtn.Location = new System.Drawing.Point(124, 116);
            this.deleteStuBtn.Name = "deleteStuBtn";
            this.deleteStuBtn.Size = new System.Drawing.Size(104, 23);
            this.deleteStuBtn.TabIndex = 2;
            this.deleteStuBtn.Text = "deleteRecord";
            this.deleteStuBtn.UseVisualStyleBackColor = true;
            this.deleteStuBtn.Click += new System.EventHandler(this.DeleteStuBtn_Click);
            // 
            // deleteStuText
            // 
            this.deleteStuText.Location = new System.Drawing.Point(178, 78);
            this.deleteStuText.Name = "deleteStuText";
            this.deleteStuText.Size = new System.Drawing.Size(147, 20);
            this.deleteStuText.TabIndex = 1;
            this.deleteStuText.TextChanged += new System.EventHandler(this.DeleteStuText_TextChanged);
            // 
            // DeleteStuLabel
            // 
            this.DeleteStuLabel.AutoSize = true;
            this.DeleteStuLabel.Location = new System.Drawing.Point(20, 81);
            this.DeleteStuLabel.Name = "DeleteStuLabel";
            this.DeleteStuLabel.Size = new System.Drawing.Size(152, 13);
            this.DeleteStuLabel.TabIndex = 0;
            this.DeleteStuLabel.Text = "Enter ID Of Student to Delete: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.deleteStuPanel);
            this.Controls.Add(this.viewAttenPanel);
            this.Controls.Add(this.markAttenPanel);
            this.Controls.Add(this.topThreePanel);
            this.Controls.Add(this.allStudentPanel);
            this.Controls.Add(this.nameSearchPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSearchGrid)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.nameSearchPanel.ResumeLayout(false);
            this.nameSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchNameGrid)).EndInit();
            this.allStudentPanel.ResumeLayout(false);
            this.allStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentGrid)).EndInit();
            this.topThreePanel.ResumeLayout(false);
            this.topThreePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topThreeGrid)).EndInit();
            this.markAttenPanel.ResumeLayout(false);
            this.markAttenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markAttenGrid)).EndInit();
            this.viewAttenPanel.ResumeLayout(false);
            this.viewAttenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAttenGrid)).EndInit();
            this.deleteStuPanel.ResumeLayout(false);
            this.deleteStuPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView idSearchGrid;
        private System.Windows.Forms.Panel nameSearchPanel;
        private System.Windows.Forms.DataGridView searchNameGrid;
        private System.Windows.Forms.Button seachNameBtn;
        private System.Windows.Forms.TextBox searchNameText;
        private System.Windows.Forms.Label nameSeachLabel;
        private System.Windows.Forms.Panel allStudentPanel;
        private System.Windows.Forms.DataGridView allStudentGrid;
        private System.Windows.Forms.Label allStudentLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn departCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Panel topThreePanel;
        private System.Windows.Forms.DataGridView topThreeGrid;
        private System.Windows.Forms.Label topThreeLabel;
        private System.Windows.Forms.Panel markAttenPanel;
        private System.Windows.Forms.DataGridView markAttenGrid;
        private System.Windows.Forms.Label markAttenLabel;
        private System.Windows.Forms.Panel viewAttenPanel;
        private System.Windows.Forms.DataGridView viewAttenGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.Label viewAttenLabel;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.Panel deleteStuPanel;
        private System.Windows.Forms.Button deleteStuBtn;
        private System.Windows.Forms.TextBox deleteStuText;
        private System.Windows.Forms.Label DeleteStuLabel;
    }
}

