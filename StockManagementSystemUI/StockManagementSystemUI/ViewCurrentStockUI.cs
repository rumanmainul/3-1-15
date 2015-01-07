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
    public partial class ViewCurrentStockUI : Form
    {
        private List<StockManagement> allItemList;
        public ViewCurrentStockUI(List<StockManagement> stockManagementList)
        {
            allItemList = stockManagementList;
            InitializeComponent();
        }

        private void ViewCurrentStockUI_Load(object sender, EventArgs e)
        {
            viewCurrentListView.Items.Clear();
            foreach (StockManagement stockManagement in allItemList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = stockManagement.ItemId.ToString();
                aListViewItem.SubItems.Add(stockManagement.ItemQuantity.ToString());
                viewCurrentListView.Items.Add(aListViewItem);
            }
        }
    }
}
