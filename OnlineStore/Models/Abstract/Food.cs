using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Abstract
{
   public abstract class Food
    {
        public string name { get; set; }
        public string kcal { get; set; }
        public string details { get; set; }
        public string price { get; set; }
        public string image { get; set; }

        public Food(string name, string kcal, string details, string price, string image)
        {
            this.name = name;
            this.kcal = kcal;
            this.details = details;
            this.price = price;
            this.image = image;
        }
    }
}
