using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_GUI
{
    internal class Store
    {
        DBConnection db;

        public Store()
        {
            db = new DBConnection();
        }
        public DataTable KnightTable()
        {
            return db.ItemsTable();
        }
        public DataTable FilterByAbovePrice(int price)
        {
            return db.FilterByAbovePrice(price);
        }

        public DataTable InsertItem(Item item)
        {
            return db.InsertItem(item);
        }

        public DataTable DeleteItem(int code)
        {
            return db.DeleteItem(code);
        }

        public void Update(DataTable table)
        {
            db.UpdateDB(table);
        }
    }
}


