using System;
using System.Collections.Generic;


namespace GinSki.Models
{
    public class InventoryRental
    {
        public String IdUser { get; set; }
        public List<Inventory> listInvertory { get; set; }
        public int PriceOfHour { get; set; }
        public DateTime DateArend { get; set; }
    }
}