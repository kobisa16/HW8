using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_GUI
{
    internal class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        public Item(int code, string name, double price, string description)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }


    }
}
