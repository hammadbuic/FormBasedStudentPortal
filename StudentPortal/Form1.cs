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
        String searchById,searchByName;
        public Form1()
        {
            InitializeComponent();
        }
        static List<Student> getTopThreeStudents(ref int firstIndex, ref int secondIndex, ref int thirdIndex, List<Student> list)
        {
            List<Student> resultList = new List<Student>();
            firstIndex = 0;
            secondIndex = 0;
            thirdIndex = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[firstIndex].gpa < list[i].gpa)
                {
                    thirdIndex = secondIndex;
                    secondIndex = firstIndex;
                    firstIndex = i;
                }
                else if (list[secondIndex].gpa < list[i].gpa && list[secondIndex].gpa < list[firstIndex].gpa && list[firstIndex].gpa != list[i].gpa || list[secondIndex].gpa == list[firstIndex].gpa)
                {
                    secondIndex = i;
                }
                else if (list[thirdIndex].gpa < list[i].gpa && list[thirdIndex].gpa < list[secondIndex].gpa && list[secondIndex].gpa != list[i].gpa || list[thirdIndex].gpa == list[secondIndex].gpa)
                {
                    thirdIndex = i;
                }
            }
            resultList.Add(list[firstIndex]);
            resultList.Add(list[secondIndex]);
            resultList.Add(list[thirdIndex]);
            return resultList;
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
            streamReader.Close();
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
            nameSearchPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
            profilePanel.Visible = true;
        }

        private void SearchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            nameSearchPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
            searchPanel.Visible = true;
            idSearchGrid.Rows.Clear();
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
            idSearchGrid.Rows.Clear();
            for (int i = 0; i < listForId.Count; i++)
            {
                if (listForId[i].id == searchById)
                {
                    MessageBox.Show("Name: " + listForId[i].name);
                    // learn grid and display data

                    int n = idSearchGrid.Rows.Add();
                    idSearchGrid.Rows[n].Cells[0].Value = listForId[i].id;
                    idSearchGrid.Rows[n].Cells[1].Value = listForId[i].name;
                    idSearchGrid.Rows[n].Cells[2].Value = listForId[i].gpa;
                    idSearchGrid.Rows[n].Cells[3].Value = listForId[i].department;
                    idSearchGrid.Rows[n].Cells[4].Value = listForId[i].university;
                    //idSearchGrid.Rows[n].Cells[5].Value = listForId[i].attendance;
                }
            }
            // Empty Grid
        }

        private void SeachNameBtn_Click(object sender, EventArgs e)
        {
            List<Student> listSearchName = new List<Student>();
            getListFile(ref listSearchName);
            searchNameGrid.Rows.Clear();
            for(int i=0;i<listSearchName.Count;i++)
            {
                if(listSearchName[i].name==searchByName)
                {
                    MessageBox.Show("Name Found: " + listSearchName[i].name);

                    int n = searchNameGrid.Rows.Add();
                    searchNameGrid.Rows[n].Cells[0].Value = listSearchName[i].id;
                    searchNameGrid.Rows[n].Cells[1].Value = listSearchName[i].name;
                    searchNameGrid.Rows[n].Cells[2].Value = listSearchName[i].gpa;
                    searchNameGrid.Rows[n].Cells[3].Value = listSearchName[i].department;
                    searchNameGrid.Rows[n].Cells[4].Value = listSearchName[i].university;
                    //searchNameGrid.Rows[n].Cells[5].Value = listSearchName[i].attendance;
                }
            }
            // Empty Grid or it will add in the data
        }

        private void SearchByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
            nameSearchPanel.Visible = true;
            searchNameGrid.Rows.Clear();
        }

        private void ListOfAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            nameSearchPanel.Visible = false;
            topThreePanel.Visible = false;
            allStudentPanel.Visible = true;
            allStudentGrid.Rows.Clear();
            List<Student> listForAll = new List<Student>();
            getListFile(ref listForAll);
            //testDataGrid.DataSource = listForAll;
            for (int n = 0; n < listForAll.Count; n++)
            {
                int i = allStudentGrid.Rows.Add();
                allStudentGrid.Rows[i].Cells[0].Value = listForAll[n].id;
                allStudentGrid.Rows[i].Cells[1].Value = listForAll[n].name;
                allStudentGrid.Rows[i].Cells[2].Value = listForAll[n].gpa;
                allStudentGrid.Rows[i].Cells[3].Value = listForAll[n].department;
                allStudentGrid.Rows[i].Cells[4].Value = listForAll[n].university;
                //allStudentGrid.Rows[i].Cells[5].Value = listForAll[n].attendance;
            }
            // MessageBox.Show(listForAll[0].name);


        }

        private void Top3StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //topThreeGrid.Rows.Clear();
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            nameSearchPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = true;
            List<Student> listForTop = new List<Student>();
            getListFile(ref listForTop);
            int firstLargest = -1;
            int secondLargest = -1;
            int thirdLargest = -1;
            List<Student> topThreeList=getTopThreeStudents(ref firstLargest, ref secondLargest, ref thirdLargest, listForTop);
            topThreeGrid.DataSource = topThreeList;
        }

        private void SeachNameText_TextChanged(object sender, EventArgs e)
        {
            searchByName = searchNameText.Text;
        }
    }
}
