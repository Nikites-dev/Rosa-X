using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;


namespace GinSki.Models
{
    public class InventoryRental
    {
        [BsonIgnoreIfDefault]
        public List<Inventory> listInventory = new List<Inventory>();
        
        [BsonIgnoreIfDefault]
        public DateTime DateArend { get; set; }
        
    }
}