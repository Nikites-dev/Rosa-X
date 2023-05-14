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
        public int HeightSize { get; set; }
    
        [BsonIgnoreIfDefault]
        public int PriceOfHour { get; set; }

        [BsonIgnoreIfDefault]
        public DateTime StartArend { get; set; }
        [BsonIgnoreIfDefault]
        public DateTime EndArend { get; set; }

    }
}