﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{
    internal class Insect:Arthropod//昆虫
    {
        public Insect(DateTime bd, string n,float wei,float w = 0, float h = 0, float d = 0) : base(bd,n, wei, w, h, d)
        {

        }
    }
}
