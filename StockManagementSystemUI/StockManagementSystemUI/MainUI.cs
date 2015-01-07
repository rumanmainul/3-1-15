using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemUI
{
    public partial class MainUI : Form
    {
        List<StockManagement> stockManagementList = new List<StockManagement>(); 
        public MainUI()
        {
            InitializeComponent();
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInUI aStockInUI = new StockInUI(stockManagementList);
            aStockInUI.Show();
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            StockOutUI aStockOutUI = new StockOutUI(stockManagementList);
            aStockOutUI.Show();
        }

        private void viewCurrentStockButton_Click(object sender, EventArgs e)
        {
            ViewCurrentStockUI aCurrentStockUI = new ViewCurrentStockUI(stockManagementList);
            aCurrentStockUI.Show();
        }

    }
}
