using System;

namespace GinSki.Models
{
    public class Client
    {
        public String FName { get; set; }
        public String LName { get; set; }
        public String PName { get; set; }
        public DateTime DateBirth { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }

        public InventoryRental InventoryRental { get; set; }
        public Skipass Skipass { get; set; }
    }
}