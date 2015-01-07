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
    public partial class StockInUI : Form
    {
        private List<StockManagement> aStockManagementList; 
        public StockInUI(List<StockManagement> stockManagementList)
        {
            aStockManagementList = stockManagementList;
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(addItemIdTextBox.Text);
            int itemQuantity = Convert.ToInt32(addQuantityTextBox.Text);
            StockManagement aStockManagement = new StockManagement(itemId, itemQuantity);
            
            string alert = aStockManagement.AddItem(aStockManagementList,aStockManagement);
            MessageBox.Show(alert);
        }

    }
}
