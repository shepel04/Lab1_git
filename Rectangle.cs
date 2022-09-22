using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Side
    {
        private double length;       
        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0) length = value;
                else   
                    throw new Exception("Length can`t be negative");
                
            }
            
        }
        public Side(double length) => this.Length = length;
    }
   
    class Rectangle
    {        
        Side[] _side;
        public Rectangle(Side[] side) => this._side = side;
        public Side this[int index]
        {
            
            get 
            {
                if (index >= 0 && index < _side.Length)
                    return _side[index]; 
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {

                if(index >= 0 && index < _side.Length)
                _side[index] = value; 
            }
        }

        


    }
}
