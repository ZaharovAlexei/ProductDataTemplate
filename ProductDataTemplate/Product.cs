using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataTemplate
{
    public enum Categories
    {
        Meal,
        Appliances
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string ImageProduct { get; set; }
        public Categories Category { get; set; }
    }
}
