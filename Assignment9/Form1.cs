using Assignment9.Business_Layer;
using Assignment9.Data_Layer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBDB;

namespace Assignment9
{
    public partial class Form1 : Form
    {
        IBusinessInitialize _ibInitialize = null;
        IBusinessStdManagement _ibStdMng = null;
        public Form1()
        {
            InitializeComponent();
            _ibInitialize = new Business();
            _ibStdMng = new Business();
        }

        ArrayList AL = new ArrayList();
        private void addStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.InitialDirectory = "C:\\Users\\SOMASUNDARAM\\Desktop";
            Open.Filter = "Text Files|*.txt|Docx Files|*.doc";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                string Filename = Open.FileName;
                FileInfo FI = new FileInfo(Filename);
                Stream str = FI.Open(FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(str);
                string RL = SR.ReadLine();
                Char[] Sep = { ',' };
                int c = 0;
                while (RL != null)
                {
                    string[] parts = RL.Split(Sep);
                    Students s1 = new Students();
                    s1.Studentid = parts[0];
                    s1.Firstname = parts[1];
                    s1.Lastname = parts[2];
                    s1.Streetaddress = parts[3];
                    s1.City = parts[4];
                    s1.State = parts[5];
                    s1.Telephone = parts[6];
                    AL.Add(s1);
                    c = _ibInitialize.InitializeStudents(s1.Studentid, s1.Firstname, s1.Lastname, s1.Streetaddress, s1.City, s1.State, s1.Telephone);
                    break;
                }
                if (c != 0)
                {
                    MessageBox.Show("DataBase Initialized");
                }
                else
                {
                    MessageBox.Show("DataBase Not Initialized");
                }
            }

        }

        private void computerScienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Courses> c = _ibStdMng.ComputerCourse();
            dataGridView1.DataSource = c;
            dataGridView1.Refresh();
        }

        private void computerEngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Courses> c = _ibStdMng.CECourse();
            dataGridView1.DataSource = c;
            dataGridView1.Refresh();
        }

        private void electricalEngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Courses> c = _ibStdMng.EECourse();
            dataGridView1.DataSource = c;
            dataGridView1.Refresh();
        }

        private void mathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Courses> c = _ibStdMng.Math();
            dataGridView1.DataSource = c;
            dataGridView1.Refresh();

        }

        private void technologyManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Courses> c = _ibStdMng.TMCourse();
            dataGridView1.DataSource = c;
            dataGridView1.Refresh();
        }

        private void addDepartmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.InitialDirectory = "C:\\Users\\SOMASUNDARAM\\Desktop";
            Open.Filter = "Text Files|*.txt|Docx Files|*.doc";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                string Filename = Open.FileName;
                FileInfo FI = new FileInfo(Filename);
                Stream str = FI.Open(FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(str);
                string RL = SR.ReadLine();
                Char[] Sep = { ',' };
                int c = 0;
                while (RL != null)
                {
                    string[] parts = RL.Split(Sep);
                    Departments d1 = new Departments();
                    d1.DepartmentID1 = int.Parse(parts[0]);
                    d1.DepartmentName1 = parts[1];
                    AL.Add(d1);
                    c = _ibInitialize.InitializeDept(d1.DepartmentID1, d1.DepartmentName1);
                    break;
                }
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if(f2.ShowDialog() == DialogResult.OK)
            { }
        }
    }
}