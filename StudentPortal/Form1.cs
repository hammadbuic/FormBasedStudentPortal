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
        String path = System.Configuration.ConfigurationManager.AppSettings["Path"];
      
        Student student = new Student();
        String searchById, searchByName, deleteId;
        public Form1()
        {
            InitializeComponent();
        }
        private bool isIdPresent(string str)
        {
            bool result=false;
            List<Student> listIdCheck = new List<Student>();
            getListFile(ref listIdCheck);
            for(int i=0;i<listIdCheck.Count;i++)
            {
                if(listIdCheck[i].id==str)
                {
                    result = true;
                }
            }
            return result;
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
            StreamReader streamReader = new StreamReader(path);
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
            //get list and check id

            if (string.IsNullOrEmpty(student.id) || string.IsNullOrEmpty(student.name) || Double.IsNaN(student.gpa) || string.IsNullOrEmpty(student.department) || string.IsNullOrEmpty(student.university))
            {
                //Notify the user
                MessageBox.Show("You left a field empty");
            }
            else if(isIdPresent(student.id))
            {
                MessageBox.Show("This ID is already alloted to a Student!\nPlease Change it and try again");
            }
            else
            {
                student.attendance = false;
                StreamWriter streamWriter = new StreamWriter(path, append: true);
                streamWriter.WriteLine(student.id);
                streamWriter.WriteLine(student.name);
                streamWriter.WriteLine(student.gpa);
                streamWriter.WriteLine(student.department);
                streamWriter.WriteLine(student.university);
                streamWriter.WriteLine(student.attendance);
                streamWriter.Close();
                MessageBox.Show("Data is written in File    " + student.name);
                idText.Text = "";
                nameText.Text = "";
                gpaText.Text = "";
                departmentText.Text = "";
                uniText.Text = "";
            }
        }

        private void CreateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
            nameSearchPanel.Visible = false;
            deleteStuPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
            markAttenPanel.Visible = false;
            viewAttenPanel.Visible = false;
            profilePanel.Visible = true;
        }

        private void SearchByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            nameSearchPanel.Visible = false;
            deleteStuPanel.Visible = false;
            markAttenPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
            searchPanel.Visible = true;
            viewAttenPanel.Visible = false;
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
                    break;
                    //idSearchGrid.Rows[n].Cells[5].Value = listForId[i].attendance;
                }
            }
            searchIdText.Text = "";
            // Empty Grid
        }

     

        private void SearchByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAttenPanel.Visible = false;
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            markAttenPanel.Visible = false;
            allStudentPanel.Visible = false;
            deleteStuPanel.Visible = false;
            topThreePanel.Visible = false;
            nameSearchPanel.Visible = true;
            searchNameGrid.Rows.Clear();
        }

        private void ListOfAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAttenPanel.Visible = false;
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            deleteStuPanel.Visible = false;
            markAttenPanel.Visible = false;
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
            viewAttenPanel.Visible = false;
            deleteStuPanel.Visible = false;
            searchPanel.Visible = false;
            markAttenPanel.Visible = false;
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

        private void MarkAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAttenPanel.Visible = false;
            markAttenPanel.Visible = true;
            deleteStuPanel.Visible = false;
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            nameSearchPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
            List<Student> listAttenMark = new List<Student>();
            getListFile(ref listAttenMark);
            markAttenGrid.DataSource = listAttenMark;
        }

        private void MarkAttenGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexAtten = e.RowIndex;
            List<Student> listAttenMark = new List<Student>();
            getListFile(ref listAttenMark);
            if(listAttenMark[indexAtten].attendance==true)
            {
                listAttenMark[indexAtten].attendance = false;
            }
            else if(listAttenMark[indexAtten].attendance==false)
            {
                listAttenMark[indexAtten].attendance = true;
            }
            StreamWriter writer = new StreamWriter(path);
            writer.Write("");
            writer.Close();
            writer = File.AppendText(path);
            for (int i = 0;  i < listAttenMark.Count;i++)
            {
                writer.WriteLine(listAttenMark[i].id);
                writer.WriteLine(listAttenMark[i].name);
                writer.WriteLine(listAttenMark[i].gpa);
                writer.WriteLine(listAttenMark[i].department);
                writer.WriteLine(listAttenMark[i].university);
                writer.WriteLine(listAttenMark[i].attendance);
            }
            writer.Close();
        }

        private void ViewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAttenPanel.Visible = true;
            markAttenPanel.Visible = false;
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            nameSearchPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
            deleteStuPanel.Visible = false;
            List<Student> listView = new List<Student>();
            getListFile(ref listView);
            for (int i = 0; i < listView.Count; i++)
            {
                int n = viewAttenGrid.Rows.Add();
                viewAttenGrid.Rows[n].Cells[0].Value = listView[i].id;
                viewAttenGrid.Rows[n].Cells[1].Value = listView[i].name;
                if(listView[i].attendance==true)
                {
                    viewAttenGrid.Rows[n].Cells[2].Value = "Present";
                }
                else if(listView[i].attendance==false)
                {
                    viewAttenGrid.Rows[n].Cells[2].Value = "Absent";
                }
            }
        }

        private void DeleteStuText_TextChanged(object sender, EventArgs e)
        {
            deleteId = deleteStuText.Text;
        }

        private void DeleteStuBtn_Click(object sender, EventArgs e)
        {
            List<Student> listDelete = new List<Student>();
            getListFile(ref listDelete);
            for (int i = 0; i < listDelete.Count-1; i++)
            {
                if (listDelete[i].id == deleteId)
                {
                    listDelete.RemoveAt(i);
                    materialLabel7.Text = listDelete[i].name;
                    materialLabel8.Text = listDelete[i].id;
                    materialLabel9.Text = Convert.ToString(listDelete[i].gpa);
                    materialLabel10.Text = listDelete[i].department;
                    materialLabel11.Text = listDelete[i].university;
                }
            }
            StreamWriter stream = new StreamWriter(path);
            stream.Write("");
            stream.Close();
            stream = File.AppendText(path);
            for (int i = 0; i < listDelete.Count; i++)
            {
                stream.WriteLine(listDelete[i].id);
                stream.WriteLine(listDelete[i].name);
                stream.WriteLine(listDelete[i].gpa);
                stream.WriteLine(listDelete[i].department);
                stream.WriteLine(listDelete[i].university);
                stream.WriteLine(listDelete[i].attendance);
            }
            stream.Close();
            MessageBox.Show("Record is Deleted Successfully");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(student.name))
            {
                MessageBox.Show("You haven't entered student name!\nPlease Enter Student Name First");
            }
            else
            {
                List<Student> listSearchName = new List<Student>();
                getListFile(ref listSearchName);
                searchNameGrid.Rows.Clear();
                for (int i = 0; i < listSearchName.Count; i++)
                {
                    if (listSearchName[i].name == searchByName)
                    {
                        int n = searchNameGrid.Rows.Add();
                        searchNameGrid.Rows[n].Cells[0].Value = listSearchName[i].id;
                        searchNameGrid.Rows[n].Cells[1].Value = listSearchName[i].name;
                        searchNameGrid.Rows[n].Cells[2].Value = listSearchName[i].gpa;
                        searchNameGrid.Rows[n].Cells[3].Value = listSearchName[i].department;
                        searchNameGrid.Rows[n].Cells[4].Value = listSearchName[i].university;
                        //searchNameGrid.Rows[n].Cells[5].Value = listSearchName[i].attendance;
                        searchNameText.Text = "";
                    }
                }
            }
            // Empty Grid or it will add in the data
        }

        private void SearchNameText_TextChanged(object sender, EventArgs e)
        {
            searchByName = searchNameText.Text;
        }

        private void DeleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteStuPanel.Visible = true;
            viewAttenPanel.Visible = false;
            markAttenPanel.Visible = false;
            profilePanel.Visible = false;
            searchPanel.Visible = false;
            nameSearchPanel.Visible = false;
            allStudentPanel.Visible = false;
            topThreePanel.Visible = false;
        }
    }
}
// Deal with exceptions Empty textt boxes
// Deal with Gpa text box should be double
// Deal with id shouldn't accept if if it is already assigned
// remove tool strip for search and replace it with radio buttons
