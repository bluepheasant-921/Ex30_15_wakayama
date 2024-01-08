using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_15_wakayama
{
   
    class Car:Thing
    {
        readonly private string _carModel;//車種
        public string carModel
        {
            get { return _carModel; }
        }
        public Car(string carModel, string n, float wei, float w = 0, float h = 0, float d = 0) : base(n, wei, w, h, d)
        { 
           this._carModel = carModel;
        }
    }
}
