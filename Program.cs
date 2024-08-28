using System;

namespace LopHinhChuNhat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double width = 10;
            double heigtht = 20;
            Rectangle rectangle = new Rectangle(width, heigtht);
            rectangle.Display();
            Console.WriteLine("Dien tich: "+rectangle.GetArea());
            Console.WriteLine("Chu vi: "+rectangle.GetParimeter());            
        }
    }
}