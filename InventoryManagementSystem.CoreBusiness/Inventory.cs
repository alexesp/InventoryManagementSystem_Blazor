using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.CoreBusiness
{
    public class Inventory
    {
        public int InventoriId { get; set; }
        public string InventoryName { get; set; }
        public int Quantiry { get; set; }
        public double Price { get; set; }
    }
}
