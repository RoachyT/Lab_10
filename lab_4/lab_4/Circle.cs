using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;

        }

        public double CalculateCircumference()
        {
            // c = 2*pi*R
            return  2 * Math.PI * _radius;
        }

        public string CalculateFormattedCircumference()
        {
            //return strings
            //call format number 
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            //start here and do math that calculates the area 
            // A = PI * R^2
            return Math.PI * _radius * _radius;
            
            //return doubles 
        }

        public string CalculateFormattedArea()
        {
            //return strings of numbers w 2/ decimal places 
            // call format number  and reference calculated area method 

            return FormatNumber(CalculateArea());

        }

        private string FormatNumber(double x)
        {

            // return a string that rounds to 2 decimal places 
            return Math.Round(x,2).ToString();
        }


    }
}
