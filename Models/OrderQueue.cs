using System;
namespace Bartender_Application.Models
{
    public class OrderQueue
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int DrinkID { get; set; }

        public virtual DrinkMenu DrinkMenu { get; set; } 
    }
}

