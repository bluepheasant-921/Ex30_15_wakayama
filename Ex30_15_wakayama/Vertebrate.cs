using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{
    class Vertebrate : Animal//脊椎動物
    {
        public Vertebrate(DateTime bd, int lifespan, string n, float wei, float w = 0, float h = 0, float d = 0) : base(bd, lifespan, n, wei, w, h, d)
        {

        }
    }
}
