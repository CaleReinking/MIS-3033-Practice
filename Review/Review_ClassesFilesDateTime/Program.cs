using System;
using System.Collections.Generic;
using System.Data;

namespace Review_ClassesFilesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {//Classes
            Rectangle rec1 = new Rectangle();
            rec1.height = 10;
            rec1.width = 20;

            Rectangle rec2 = new Rectangle(5, 2);

            Console.WriteLine($"The area of rec1 is {rec1.area()}");

            Console.WriteLine($"The area of rec2 is {rec2.area()}");

           
            List<Rectangle> rectangles = new List<Rectangle>();
 //Add existing rectangles to a list
            rectangles.Add(rec1);
            rectangles.Add(rec2);

            //Add new rectangle 
            rectangles.Add(new Rectangle(7, 7));

            foreach (var rec in rectangles)
            {
                Console.WriteLine(rec);
                Console.Write("The rectangle has a width of {rec.width} and hight of {rec.height}");
                Console.WriteLine($"The area of the rectangle is {rec.area()}");
            }
        }
    }
}
