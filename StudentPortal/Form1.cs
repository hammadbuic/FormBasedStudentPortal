using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentPortal
{
    public partial class Form1 : Form
    {
        Student student = new Student();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
            profilePanel.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = true;
            searchPanel.Visible = false;
        }

        private void IdText_TextChanged(object sender, EventArgs e)
        {
            student.id = idText.Text;
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            student.name = nameText.Text;
        }

        private void GpaText_TextChanged(object sender, EventArgs e)
        {
            student.gpa = Convert.ToDouble(gpaText.Text);
        }

        private void DepartmentText_TextChanged(object sender, EventArgs e)
        {
            student.department = departmentText.Text;
        }

        private void UniText_TextChanged(object sender, EventArgs e)
        {
            student.university = uniText.Text;
        }

        private void EnterRecord_Click(object sender, EventArgs e)
        {
            student.attendance = false;
            StreamWriter streamWriter = new StreamWriter(@"E:\\BSE 5A\\VP\\VP assign 1\\VP Asssignment FormBasedStudentPortal\\StudentPortal\\data.txt", append: true);
            streamWriter.WriteLine(student.id);
            streamWriter.WriteLine(student.name);
            streamWriter.WriteLine(student.gpa);
            streamWriter.WriteLine(student.department);
            streamWriter.WriteLine(student.university);
            streamWriter.WriteLine(student.attendance);
            streamWriter.Close();
            MessageBox.Show("Data is written in File    "+ student.name);
        }
    }
}
