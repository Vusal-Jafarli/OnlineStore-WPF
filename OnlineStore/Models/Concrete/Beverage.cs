﻿using OnlineStore.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Beverage : Food
    {
        public Beverage(string name, string kcal, string details, string price, string image) : base(name, kcal, details, price, image)
        {
        }
    }
}
