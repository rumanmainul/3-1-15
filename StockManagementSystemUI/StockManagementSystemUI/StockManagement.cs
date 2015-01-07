using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI
{
    public class StockManagement
    {
        private List<StockManagement> aManagementsList;
        public int ItemId { set; get; }
        public int ItemQuantity { set; get; }

        public StockManagement(int itemId, int itemQuantity)
        {
            ItemId = itemId;
            ItemQuantity = itemQuantity;
        }

        public string AddItem(List<StockManagement> aStockManagementList, StockManagement aStockManagement)
        {
            aManagementsList = aStockManagementList;
            if (IsFoundItemId(aStockManagement.ItemId, aStockManagement.ItemQuantity))
            {               
                return "Item Quantity Update";
            }
            
                aManagementsList.Add(aStockManagement);
           
            return "Add Succesfully";
        }


        private bool IsFoundItemId(int itemID, int itemQuantity)
        {
            foreach (StockManagement storeitemsId in aManagementsList)
            {
                if (storeitemsId.ItemId == itemID)
                {
                    storeitemsId.ItemQuantity += itemQuantity;
                    return true;
                }
            }
            return false;
        }

        public string outItemFormList(List<StockManagement> stockOutList, StockManagement aStockManagement)
        {
            aManagementsList = stockOutList;
            if (IsAvailableQuantity(aStockManagement.ItemQuantity))
            {
                return "you are trying  to stock out "+aStockManagement.ItemQuantity+" items ";
            }
            else
            {
                return "Item found";
            }
        }

        private bool IsAvailableQuantity(int p)
        {
            foreach (StockManagement itemsStock in aManagementsList)
            {
                if (itemsStock.ItemQuantity < p)
                {
                    return true;
                }
                
            }
            return false;
        }

    }
}
