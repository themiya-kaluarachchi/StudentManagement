using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string course = txtCourse.Text;
            double gpa = double.Parse(txtGPA.Text);

            Student student = new Student(id, name, course, gpa);
            students.Add(student);
            RefreshList();
            ClearInputs();

        }

        private void RefreshList()
        {
            lstStudents.Items.Clear();
            foreach (Student s in students)
                lstStudents.Items.Add(s);
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtCourse.Clear();
            txtGPA.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex >= 0)
            {
                students.RemoveAt(lstStudents.SelectedIndex);
                RefreshList();
            }
        }
    }
}
