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
    public partial class StockOutUI : Form
    {
        private List<StockManagement> stockOutList;
        public StockOutUI(List<StockManagement> stockManagementList)
        {
            InitializeComponent();
            stockOutList = stockManagementList;
        }

        private void outItemButton_Click(object sender, EventArgs e)
        {
            int outItemId = Convert.ToInt32(outItemIdTextBox.Text);
            int outItemQuantity = Convert.ToInt32(outQuantityTextBox.Text);
            StockManagement aStockManagement = new StockManagement(outItemId, outItemQuantity);
            string alert = aStockManagement.outItemFormList(stockOutList, aStockManagement);
            MessageBox.Show(alert);
        }
    }
}
