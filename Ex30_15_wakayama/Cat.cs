﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{
    internal class Cat:Animal
    {
        public Cat(DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(bd, n, w, h, d)
        {

        }
    }
}
