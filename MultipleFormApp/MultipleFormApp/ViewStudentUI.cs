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
    public partial class ViewStudentUI : Form
    {
        List<Student> studentsList = new List<Student>(); 
        public ViewStudentUI(List<Student>aStudents)
        {
            studentsList = aStudents;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Student student in studentsList)
            {
                studentListBox.Items.Add(student.Name + " " + student.Email);
            }
        }

        
    }
}
