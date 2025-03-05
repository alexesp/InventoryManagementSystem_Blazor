using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.PluginInterfaces;


namespace InventoryManagementSystem.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory { InventoriId = 1, InventoryName = "Bike Seat", Quantiry = 10, Price = 2 },
                new Inventory { InventoriId = 2, InventoryName = "Bike Body", Quantiry = 10, Price = 15 },
                new Inventory { InventoriId = 3, InventoryName = "Bike Wheels", Quantiry = 20, Price = 8 },
                new Inventory { InventoriId = 4, InventoryName = "Bike Pedels", Quantiry = 10, Price = 1 }
            };
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return await Task.FromResult(_inventories);
            }
            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
