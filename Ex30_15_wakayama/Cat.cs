using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{
    internal class Cat : Mammalian
    {
        readonly string _pedigree;//血統
        public string pedigree
        {
            get { return _pedigree; }
        }
        public Cat(string pedigree, DateTime bd, string n, float wei, float w = 0, float h = 0, float d = 0) : base(bd, n, wei, w, h, d)
        {
            this._pedigree = pedigree;
        }
    }
}
