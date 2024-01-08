using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{

    internal class Worker : Person
    {
        readonly private string _organization;//所属組織
        readonly private int _income;//収入
        public string organization
        {
            get { return _organization; }
        }
        public int income
        {
            get { return _income; }
        }
        public Worker(string org,int income,DateTime bd, string n, float wei, float w = 0, float h = 0, float d = 0)
            : base(bd, n, w, h, d)
        {
            this._organization = org;
            this._income = income;
        }
    }
}
