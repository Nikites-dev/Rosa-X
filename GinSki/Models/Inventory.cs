using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GinSki.Models
{
    public class Inventory
    {

        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonIgnoreIfDefault]
        public String Name { get; set; }
        [BsonIgnoreIfDefault]
        public int IdTypeInverory { get; set; }
        [BsonIgnoreIfDefault]
        public int Height { get; set; }
        [BsonIgnoreIfDefault]
        public int Size { get; set; }
        [BsonIgnoreIfDefault]
        
        public int PriceOfHour { get; set; }
        [BsonIgnoreIfDefault]
        public int Count { get; set; }
        
    }
}