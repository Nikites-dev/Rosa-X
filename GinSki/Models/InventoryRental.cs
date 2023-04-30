using System;
using System.Collections.Generic;


namespace GinSki.Models
{
    public class InventoryRental
    {
        public List<Inventory> listInventory = new List<Inventory>();
      
        public DateTime DateArend { get; set; }
        
    }
}