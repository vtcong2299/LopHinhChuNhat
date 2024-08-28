using System;

namespace  LopHinhChuNhat
{
    public class Rectangle
    {
        double rong;
        double dai;
        public Rectangle() 
        {
            
        }
        public Rectangle(double width, double heigtht)
        {
            this.rong = width;
            this.dai = heigtht;
        }

        public double GetArea()
        {
            double area= rong * dai;
            return area;
        }
        public double GetParimeter()
        {
            double parimeter = 2*(rong+dai);
            return parimeter;
        }
        public void Display()
        {
            Console.WriteLine("Hinh chu nhat co chieu dai "+dai+" va chieu rong "+ rong);
        }
    }
}