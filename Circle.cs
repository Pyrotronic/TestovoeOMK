using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZavod
{
    public class Circle : ICalc
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Не может быть меньше 0");
                else _radius = value;
            }
        }
        public Circle(double r) 
        {
            Radius = r;
        }
        public double GetArea()
        {
            return Math.PI *Math.Pow(Radius, 2);
        }
        public double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
