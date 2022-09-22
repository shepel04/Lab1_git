using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class TRTriangle
    {
        protected double _a;
        public double a
        {
            get { return _a; }
            set
            {
                if (value > 0) _a = value;
            }
        }
        protected double _b;
        public double b
        {
            get { return _b; }
            set
            {
                if (value > 0) _b = value;
            }
        }

        public TRTriangle()
        {
            _a = 0;
            _b = 0;
        }

        public TRTriangle(double a, double b)
        {
            this._a = a;
            this._b = b;
        }

        public TRTriangle(TRTriangle obj)
        {
            _a = obj.a;
            _b = obj.b;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public double Get_Gip()
        {
            return Math.Sqrt(_a * _a + _b * _b);
        }

        public double Get_Square()
        {
            return 0.5 * _a * _b;
        }

        public double Get_Perimeter()
        {
            return _a + _b + Get_Gip();
        }

        public static TRTriangle operator != (TRTriangle tr1, TRTriangle tr2)
        {
            return tr1 != tr2;
        }

        public static TRTriangle operator == (TRTriangle tr1, TRTriangle tr2)
        {
            return tr1 == tr2;
        }

        public static TRTriangle operator * (TRTriangle tr1, TRTriangle tr2)
        {
            return tr1 * tr2;
        }

    }

    class TRPiramid : TRTriangle
    {
        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
            }
        }

        public TRPiramid(double a, double b, double height)
        {
            this.Height = height;
            this._a = a;
            this._b = b;
        }

        public double Get_Volume()
        {
            return 0.33 * (0.5 * a * b) * Height;
        }
    }


}
