using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovoeZavod
{
    public class Rectangle:ICalc
    {
        private double _height;
        private double _width;
        public double Height {
            get
            {
                return _height;
            }
            set 
            { 
                if (value >= 0)
                {
                    _height = value;
                }
                else throw new ArgumentOutOfRangeException("Высота не может принимать отрицательные значения");
            } 
        }
        public double Width { 
            get 
            { 
                return _width;
            }
            set 
            {
                if (value >= 0)
                {
                    _width = value;
                }
                else throw new ArgumentOutOfRangeException("Ширина не может быть отрицательна");
            } 
        }
        public Rectangle(double x, double y) 
        {
            Height = y;
            Width = x;
        }
        public double GetArea()
        {
            return Height * Width;
        }
        public double GetPerimetr()
        {
            return (Height + Width) * 2;
        }
    }
}
