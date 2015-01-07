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
    public partial class AddStudent : Form
    {
        private List<Student> studentList;
        public AddStudent(List<Student> students )
        {
            InitializeComponent();
            studentList = students;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student student=new Student();
            student.Name = nameTextBox.Text;
            student.Email = emailTextBox.Text;
            studentList.Add(student);
        }
    }
}
