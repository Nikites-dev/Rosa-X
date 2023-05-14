using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GinSki.Models
{
    public class Client
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonIgnoreIfDefault]
        public String FName { get; set; }
        [BsonIgnoreIfDefault]
        public String LName { get; set; }
        [BsonIgnoreIfDefault]
        public String PName { get; set; }
        [BsonIgnoreIfDefault]
        public DateTime DateBirth { get; set; }
        [BsonIgnoreIfDefault]
        public String Phone { get; set; }
        [BsonIgnoreIfDefault]
        public String Email { get; set; }
        [BsonIgnoreIfDefault]
        
        public List<Inventory> listInventory = new List<Inventory>();
        
        [BsonIgnoreIfDefault]
        public Skipass Skipass { get; set; }
    }
}