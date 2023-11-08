using OnlineStore.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
  public class Meal : Food
    {
        public Meal(string name, string kcal, string details, string price, string image) : base(name, kcal, details, price, image)
        {
        }
    }
}
