using System;

namespace Shapes {

    class Program {

        static void Main(string[] args) {
            var shapes = new Shape[] {
                new Square(7, "box"),
                new Circle(3.5, "circle"),
                new Rectangle(5, 4, "rectangle")
            };

            foreach (var shape in shapes) {
                shape.PrintName();
                shape.PrintShapeInfo();
            }

            Console.ReadKey();

        }


    }

    public abstract class Shape {
        private string Name;

        protected Shape(string name) {
            Name = name;
        }

        protected abstract double GetArea();
        protected abstract double GetPerimeter();
        public abstract void PrintName();

        public void PrintShapeInfo() {
            var perimeter = GetPerimeter().ToString("0.00");
            var area = GetArea().ToString("0.00");
            Console.WriteLine("The area of " + Name + " is " + area);
            Console.WriteLine("The perimeter of " + Name + " is " + perimeter);
        }

    }

    public class Square : Rectangle {

        public Square(double sidelength, string name)
            : base(sidelength, sidelength, name) {
        }
        public override void PrintName() {
            Console.WriteLine("**Square**");
        }
    }

    public class Circle : Shape {

        private double Radius;

        public Circle(double radius, string name) : base(name) {
            Radius = radius;

        }
        protected override double GetArea() {
            return Radius * Radius * Math.PI;
        }
        protected override double GetPerimeter() {
            return 2 * Math.PI * Radius;
        }
        public override void PrintName() {
            Console.WriteLine("**Circle**");
        }
    }

    public class Rectangle : Shape {

        private double Length;
        private double Width;

        public Rectangle(double length, double width, string name) : base(name) {
            Width = width;
            Length = length;
        }
        protected override double GetArea() {
            return Length * Width;
        }

        protected override double GetPerimeter() {
            return Length * 2 + Width * 2;
        }
        public override void PrintName() {
            Console.WriteLine("**Rectangle**");
        }
    }
}
