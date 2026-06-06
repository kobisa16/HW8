using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Store
    {
        Item[] items;
        int totalItems = 0;
        DBConnection db = new DBConnection();

        
        public Store()
        {
            items = new Item[0];
        }

        public void AddItem(Item item)
        {
            db.AddItemToDB(item);
        }

    }
}
