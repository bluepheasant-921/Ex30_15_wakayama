using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{
    /// <summary>
    /// 物体
    /// </summary>
    class Thing
    {
        readonly public string name;
        public float weight;
        public float width;
        public float height;
        public float depth;
        public float box;
        public Thing(string n = null, float wei=0,float w = 0, float h = 0, float d = 0)
        {
            name = n;
            weight =wei;
            width = w;
            height = h;
            depth = d;
            box = w+h+d;
        }
    }
}

