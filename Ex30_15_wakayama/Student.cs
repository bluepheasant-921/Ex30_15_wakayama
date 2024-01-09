using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{
    internal class Student : Person
    {
        readonly private string _organization;//所属組織
        readonly private int _id;//学籍番号

        public string organization
        {
            get { return _organization; }
        }
        public int id
        {
            get { return _id; }
        }
        public Student(string org,int id,DateTime bd, int lifespan, string n, float wei, float w = 0, float h = 0, float d = 0) : base(bd, lifespan, n, wei, w, h, d)
        {
            this._organization=org; 
            this._id=id;
        }
    }
}
