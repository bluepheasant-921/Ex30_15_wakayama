using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{ /// <summary>
  /// 生き物
  /// </summary>
    class Life : Thing
    {
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public int _lifespan;
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        new public string name
        {
            get { return _name; }
        }
        public Life(DateTime bd,int lifespan ,string n,float wei ,float w = 0, float h = 0, float d = 0) : base(n,wei,w, h, d)
        {
            this._birthDay = bd;
            this._name = n;
            this._lifespan =lifespan;
        }
        public int GetAge()
        {
            int age = 0;
            age = DateTime.Now.Year - _birthDay.Year;
            if (_birthDay.Month > DateTime.Now.Month)
            {
                age -= 1;
            }
            else if (_birthDay.Month == DateTime.Now.Month)
            {
                if (_birthDay.Day! > DateTime.Now.Day)
                {
                    age -= 1;
                }
            }
            return age;
        }
        public bool CheckBirthday()
        {
            bool todayBirthday = false;
            if(_birthDay.Month == DateTime.Now.Month)
            {
                if(_birthDay.Day== DateTime.Now.Day)
                {
                    todayBirthday = true;
                }
            }
            return todayBirthday;
        }
        public void Introduction(Life l)
        {
            Console.WriteLine(l._name);
            Console.WriteLine(l.GetAge());
            Console.WriteLine(l.CheckBirthday());
        }
    }
}
