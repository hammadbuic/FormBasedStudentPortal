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
        String searchById;
        public Form1()
        {
            InitializeComponent();
        }
        private void getListFile(ref List<Student> list)
        {
            StreamReader streamReader = new StreamReader(@"E:\\BSE 5A\\VP\\VP assign 1\\VP Asssignment FormBasedStudentPortal\\StudentPortal\\data.txt");
            while (streamReader.EndOfStream != true)
            {
                Student s = new Student();
                s.id = streamReader.ReadLine();
                s.name = streamReader.ReadLine();
                s.gpa = Convert.ToDouble(streamReader.ReadLine());
                s.department = streamReader.ReadLine();
                s.university = streamReader.ReadLine();
                s.attendance = Convert.ToBoolean(streamReader.ReadLine());
                list.Add(s);
            }
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

        private void CreateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
            profilePanel.Visible = true;
        }

        private void SearchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            searchPanel.Visible = true;
        }

        private void SearchIdText_TextChanged(object sender, EventArgs e)
        {
            searchById = searchIdText.Text;
           
        }

        private void SearchIdBtn_Click(object sender, EventArgs e)
        {
            //design function
            List<Student> listForId = new List<Student>();
            getListFile(ref listForId);

            for (int i = 0; i < listForId.Count; i++)
            {
                if (listForId[i].id == searchById)
                {
                    MessageBox.Show("Name: " + listForId[i].name);
                    // learn grid and display data
                }
            }
        }
    }
}
