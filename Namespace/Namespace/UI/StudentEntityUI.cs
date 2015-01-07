using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Namespace.Entity;

namespace Namespace.UI
{
    public partial class StudentEntityUI : Form
    {
        public StudentEntityUI()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
        }

    }
}
