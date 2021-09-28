using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        abstract class Point
        {
            private float x;
            private float y;
            public abstract void CW();
            public abstract void Move(float x, float y);
            public abstract void Scale(float x, float y);
        }

        abstract class Circle : Point
        {
            public Point[] centre;

            public Circle(int n)
            {
                centre = new Point[n];
            }

            private float radius;

            public override void CW()
            {
                Console.WriteLine("Circle");
            }

            public override void Move(float shiftX, float shiftY)
            {
                for (int i = 0; i < centre.Length; i++)
                {
                    centre[i].Move(shiftX, shiftY);
                }
            }

            public override void Scale(float сoordinateValue, float scalFactor)
            {
                float result = сoordinateValue * scalFactor;
                Console.WriteLine(result);
            }
        }

        class Rectangle : Point
        {
            public Point[] rectVertices;

            public Rectangle(int n)
            {
                rectVertices = new Point[n];
            }

            public override void CW()
            {
                Console.WriteLine("Rectangle");
            }

            public override void Move(float shiftX, float shiftY)
            {
                for (int i = 0; i < rectVertices.Length; i++)
                {
                    rectVertices[i].Move(shiftX, shiftY);
                }
            }

            public override void Scale(float сoordinateValue, float scalFactor)
            {
                float result = сoordinateValue * scalFactor;
                Console.WriteLine(result);
            }
        }

        class Triangle : Rectangle
        {
            public Point[] triVertices;

            public Triangle(int n) : base(3)
            {
                triVertices = new Point[n];
            }

            public override void CW()
            {
                Console.WriteLine("Triangle");
            }

            public override void Move(float shiftX, float shiftY)
            {
                for (int i = 0; i < triVertices.Length; i++)
                {
                    triVertices[i].Move(shiftX, shiftY);
                }
            }

            public override void Scale(float сoordinateValue, float scalFactor)
            {
                float result = сoordinateValue * scalFactor;
                Console.WriteLine(result);
            }
        }

        class Image : Rectangle
        {
            public Point[] phigures;

            public Image(int n) : base(3)
            {
                phigures = new Point[n];
            }

            public override void CW()
            {
                Console.WriteLine("All figures");
            }

            public override void Move(float shiftX, float shiftY)
            {
                for (int i = 0; i < phigures.Length; i++)
                {
                    phigures[i].Move(shiftX, shiftY);
                }
            }

            public override void Scale(float сoordinateValue, float scalFactor)
            {
                for (int i = 0; i < phigures.Length; i++)
                {
                    phigures[i].Scale(сoordinateValue, scalFactor);
                }
            }

            public void Add(Image triangle, Image rectangle, Image circle)
            {
                List<Image> phiguresList = new List<Image>();

                phiguresList.Add(circle);
                phiguresList.Add(rectangle);
                phiguresList.Add(triangle);

                foreach (Image phigure in phigures)
                {
                    Console.WriteLine(phigure);
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
