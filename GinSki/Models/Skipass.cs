using System;

namespace GinSki.Models
{
    public class Skipass
    {
        public String Id { get; set; }
        public int IdClient { get; set; }
        public int CountDescents  { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        
    }
}