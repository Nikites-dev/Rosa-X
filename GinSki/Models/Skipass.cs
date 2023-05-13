using System;
using MongoDB.Bson.Serialization.Attributes;

namespace GinSki.Models
{
    public class Skipass
    {
        [BsonIgnoreIfDefault]
        public int CountDescents  { get; set; }
        [BsonIgnoreIfDefault]
        public DateTime StartDateTime { get; set; }
        [BsonIgnoreIfDefault]
        public DateTime EndDateTime { get; set; }
        
    }
}