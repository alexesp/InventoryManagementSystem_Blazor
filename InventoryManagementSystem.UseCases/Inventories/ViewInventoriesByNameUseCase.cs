using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.CoreBusiness;
using InventoryManagementSystem.UseCases.PluginInterfaces;

namespace InventoryManagementSystem.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;
        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this._inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
          return await _inventoryRepository.GetInventoriesByNameAsync(name);
             
        }
    }
}
