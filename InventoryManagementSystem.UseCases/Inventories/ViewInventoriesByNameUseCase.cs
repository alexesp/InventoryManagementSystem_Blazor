using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase
    {
        public IEnumerable<Inventory> ExecuteAsync(string name = "");
    }
}
