using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_25._03._23
{
    public abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Triangle : Figure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public double height { get; set; }

        public Triangle(double a, double b, double c, double h)
        {
            side1 = a;
            side2 = b;
            side3 = c;
            height = h;
        }

        public override double Area()
        {
            double maxSide = side1;
            if (side2 > maxSide) { maxSide = side2; }
            if (side3 > maxSide) { maxSide = side3; }
            if (height == side1 || height == side2 || height == side3) //проверка является ли треугольник прямоугольным
            {
                if (side1 == maxSide)
                {
                    return (side2 * side3) / 2;
                }
                else if (side2 == maxSide) { return (side1 * side3) / 2; }
                else return (side2 * side1) / 2;
            }
            return (maxSide * height) / 2;
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
    }

    public class Squere : Figure
    {
        public double _side { get; set; }

        public Squere(double side)
        {
            _side = side;
        }

        public override double Area()
        {
            return _side * _side;
        }

        public override double Perimeter()
        {
            return 4 * _side;
        }
    }

    public class Rhomb : Figure
    {
        public double _side { get; set; }
        public double _d1 { get; set; }
        public double _d2 { get; set; }

        public Rhomb(double side, double d1, double d2)
        {
            _side = side;
            _d1 = d1;
            _d2 = d2;
        }

        public override double Area() { return (_d1 * _d2) / 2; }
        public override double Perimeter() { return 4 * _side; }
    }

    public class Rectangle : Figure
    {
        public double _w { get; set; }
        public double _h { get; set; }

        public Rectangle(double w, double h)
        {
            _w = w;
            _h = h;
        }

        public override double Area()
        {
            return _w * _h;
        }

        public override double Perimeter() { return 2 * (_w + _h); }
    }

    public class Parallelogram : Figure
    {
        public double _w { get; set; }
        public double _h { get; set; }
        public double _s { get; set; }

        public Parallelogram(double w, double h, double s)
        {
            _w = w;
            _h = h;
            _s = s;
        }

        public override double Area()
        {
            return _w * _h;
        }

        public override double Perimeter() { return 2 * (_w + _s); }
    }

    public class Trapeze:Figure
    {
        public double _base1 { get; set;}
        public double _base2 { get; set; }
        public double _height { get; set; }

        public Trapeze(double base1, double base2, double height) 
        { 
            _base1 = base1;
            _base2 = base2;
            _height = height;
        }

        public override double Area() { return (_base1+_base2) * _height/2; }
        public override double Perimeter()
        {
            return _base1+_base2+2*Math.Sqrt(Math.Pow((_base2-_base1)/2,2) + Math.Pow(_height,2));
        }
    }

    public class CompoundFigure
    {
        public Figure[] figures;

        public CompoundFigure(Figure[] figures) { this.figures = figures; }
        public double Area()
        {
            double area = 0;
            foreach (Figure el in figures) { area += el.Area(); }
            return area;
        }
    }
}
