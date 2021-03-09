using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            HideAll();
            ListViewRefresh();

            if(panelName == "Dashboard")
            {
                // hide all other panels
                pnl_Students.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if(panelName == "Students")
            {
                // hide all other panels
                HideAll();
                ListViewRefresh();

                // show lable name students
                lbl_Students.Text = "Students";

                // show students
                pnl_Students.Show();

                //show colums, with name and id
                listViewStudents.Columns.Add("studentName");
                listViewStudents.Columns.Add("studentId");

                // fill the students listview within the students panel with a list of students
                Student_Service StudentService = new Student_Service();
                
                // clear the listview before filling it again
                listViewStudents.Clear();

                foreach (Student student in StudentService.GetStudents())
                {
                    ListViewItem li = new ListViewItem(student.Name);
                    li.SubItems.Add(student.Number.ToString());
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Teachers")
            {
                HideAll();
                ListViewRefresh();

                // show lable name students
                lbl_Lecturers.Text = "Teachers";

                // show Lecturers
                pnl_Lecturers.Show();

                //show colums, with name and id
                listviewLecturers.Columns.Add("TeachersName");
                listviewLecturers.Columns.Add("TeachersId");

                // fill the Lecturers listview within the Lecturer panel with a list of Lecturers
                Teacher_Service teacherService = new Teacher_Service();

                // clear the listview before filling it again
                listviewLecturers.Clear();
            }       
        }

        private void HideAll()
        {
            pnl_Dashboard.Hide();
            pnl_Students.Hide();
            pnl_Lecturers.Hide();
        }

        private void ListViewRefresh()
        {
            listViewStudents.Clear();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void pnl_Lecturers_Paint(object sender, PaintEventArgs e)
        {
            //dummie stuppid thing
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");   //dummie stuppid thing == TeachersToolStripMenuItem_Click
        }

        private void TeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }
    }
}
