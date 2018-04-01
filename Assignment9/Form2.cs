using Assignment9.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert into dbo.Table_RegCourse (StudentID,CourseNum,DepartmentName) VALUES ('" + textBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox1.Text + "')";
            int res = 1;
            if (res != 0)
            {
                MessageBox.Show("Table Updated");
            }
            else
            {
                MessageBox.Show("Table Not Updated");
            }
        }
    }
}
