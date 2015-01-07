using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleFormApp
{
    public partial class MainUI : Form
    {
        List<Student> studentList =new List<Student>();
        public MainUI()
        {
            InitializeComponent();
        }

        private void addStudentBtton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent=new AddStudent(studentList);
            addStudent.Show();
        }

        private void viewStudentButton_Click(object sender, EventArgs e)
        {
            ViewStudentUI viewStudentUi = new ViewStudentUI(studentList);
            viewStudentUi.Show();
        }
    }
}
