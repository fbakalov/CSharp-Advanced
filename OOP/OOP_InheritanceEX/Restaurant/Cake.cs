﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double grams = 250;
        private const double calories = 1000;
        private const decimal price = 5M;

        public Cake(string name)
            :base(name, price, grams, calories) 
        { }
    }
}
