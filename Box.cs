using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box_Data
{
    internal class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double l, double w, double h)
        {
            this.Length = l;
            this.Width = w;
            this.Height = h;
        }
        public double Length
        {
            get { return length; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Cannot be less than 1");
                }
                else
                {
                    length = value;
                }
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Cannot be less than 1");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Cannot be less than 1");
                }
                else
                {
                    height = value;
                }
            }
        }

        public double SurfaceArea()
        {
            return 2* this.width * this.length + 2 * this.height * this.length + 2* this.height * this.width;
        }
        public double LateralSurfaceArea()
        {
            return 2 * this.height * (this.width + this.length);
        }
        public double Volume()
        {
            return this.width * this.length * this.height;
        } 
    }
}
