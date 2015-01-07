using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace BigProjectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Saver aSaver;
        private void button1_Click(object sender, EventArgs e)
        {
            aSaver = new Saver();
            aSaver.Save();
        }
    }
}
