using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZavod
{
    public class Sqare:ICalc
    {
        private double _side;
        public double Side { 
            get
            {
                return _side;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Сторона квадрата не может быть меньше 0");
                else _side = value;
            }
        }
        public Sqare(double x) 
        { 
            Side = x;
        }
        public double GetArea ()
        {
            return Math.Pow(Side, 2);
        }
        public double GetPerimetr()
        {
            return Side * 4;
        }
    }
}
