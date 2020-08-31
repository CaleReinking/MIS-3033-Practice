using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Review_ClassesFilesDateTime
{
    public class Rectangle
    {
        public int width { get; set; }
        // Can do Width = width in public Rectangle and change this to Width
        public int height { get; set; }

        public DateTime creationDate { get; set; }
        
        public Rectangle()
        {
            width = 0;
            height = 0;
            //Add creation date
            creationDate = DateTime.Now;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            //Add creation date
            creationDate = DateTime.Now;
        }
        public double area()
        {
            return width*height;
        }
        public override string ToString()
        {
            var diff = DateTime.Now - creationDate;
            string output = $"The rectangle was created on {creationDate.DayOfWeek} {diff.TotalSeconds}  seconds ago has width of {width} and height of {height}" +
                $"the area of the rectangle is {area()}";
            return output;
        }
    }
}
