using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_11
{
    class Application
    {
        public void Main_001()
        {
            Flip flip = new Flip();
            Console.Write(flip.State() + " ");
            flip.flip();
            Console.Write(flip.State() + " ");
            flip.flip();
            Console.Write(flip.State());
            Console.ReadKey();
        }
        class Flip
        {
            private bool state;
            public Flip() { state = false; }
            public bool State() { return state; }
            public void flip() { state = !state; }
        }
        public void Main_004()
        {
            Badminton badminton = new Badminton();
            while (Convert.ToBoolean(badminton.action()))
            {
                Console.Write("{0}:{1} {2} ", badminton.score(1),
                                  badminton.score(-1), badminton.action());
                int result = Convert.ToInt32(Console.ReadLine());
                badminton.result(result);
                Console.WriteLine();
            }
            Console.WriteLine("{0}:{1}", badminton.score(1), badminton.score(-1));
            Console.ReadKey();
        }
        class Badminton
        {
            private int score_1, score_2, nextMove;
            public Badminton()
            {
                score_1 = score_2 = 0;
                nextMove = 1;
            }
            public int action()
            {
                return (score_1 > 20 && score_1 > score_2 + 1 ||
                        score_2 > 20 && score_2 > score_1 + 1) ?
                        0 : nextMove;
            }
            public int score(int playerId)
            {
                if (playerId == 1) return score_1;
                return score_2;
            }
            public void result(int playerId)
            {
                if (playerId == 1)
                {
                    ++score_1;
                    nextMove = 1;
                }
                else
                {
                    ++score_2;
                    nextMove = -1;
                }
            }
        }
        public void Main_005()
        {
            Radio radio = new Radio(3);
            print(ref radio);
            radio.set(2);
            print(ref radio);
            Console.ReadKey();
        }
        class Radio
        {
            private bool[] buttons;
            private int numberOfButtons;
            public Radio(int n)
            {
                buttons = new bool[n];
                buttons[0] = true;
                for (int index = 1; index < n; ++index)
                    buttons[index] = false;
                numberOfButtons = n;
            }
            public bool get(int n)
            {
                return buttons[n];
            }
            public int size() { return numberOfButtons; }
            public void set(int n)
            {
                for (int index = 0; index < numberOfButtons; ++index)
                    buttons[index] = false;
                buttons[n] = true;
            }
        }
        void print(ref Radio radio)
        {
            for (int index = 0; index < radio.size();)
            {
                Console.Write(radio.get(index++) + " ");
            }
            Console.WriteLine();
        }
        public void Main_010()
        {
            Console.WriteLine((new Byte()).Set(0).Set(2).Set(5).Get());
            Console.ReadKey();
        }
        class Byte
        {
            private bool[] b = new bool[8];
            public int Get()
            {
                int sum = 0;
                for (int index = 0; index < 8; ++index)
                    sum += (b[index]) ? (int)Math.Pow(2.0, (7 - index)) : 0;
                return sum;
            }
            public Byte Set(int n)
            {
                b[7 - n] = true;
                return this;
            }
        }
        class Bottle
        {
            public Bottle(double capacity)
            {
                this.capacity = capacity;
                volume = 0;
            }
            private double capacity;
            private double volume;
            public double Volume { get { return volume; } }
            public double Fill(double liquid)
            {
                volume += (capacity - Volume > liquid) ? liquid : liquid = capacity - Volume;
                return liquid;
            }
            public double Pour(double liquid)
            {
                volume -= (volume > liquid) ? liquid : liquid = volume;
                return liquid;
            }
        }
        public void Main_06()
        {
            Bottle bottle = new Bottle(4.5);
            Console.WriteLine("{0} {1} {2} {3} {4}",
                              bottle.Volume,
                              bottle.Fill(3.5),
                              bottle.Volume,
                              bottle.Pour(5.5),
                              bottle.Volume);
        }
        class Polygon
        {
            public Polygon(int corners, double sideLength)
            {
                this.corners = corners;
                this.sideLength = sideLength;
            }
            public double Area()
            {
                return 1.0 / 4 * corners * sideLength * sideLength * 1.0 / Math.Tan(Math.PI / corners);
            }
            public Polygon Scaled(double scale)
            {
                return new Polygon(corners, sideLength * scale);
            }
            public void Scale(double scale)
            {
                sideLength *= scale;
            }
            // Private properties / fields
            private int corners;
            private double sideLength;
        }
        public void Main_07()
        {
            Polygon polygon = new Polygon(7, 10.0);
            Console.WriteLine(polygon.Area());
            Console.WriteLine(polygon.Scaled(2.0).Area());
            polygon.Scale(2.0);
            Console.WriteLine(polygon.Area());
        }
        class Point
        {
            public Point X(double x)
            {
                this.x = x;
                return this;
            }
            public Point Y(double y)
            {
                this.y = y;
                return this;
            }
            public double X() { return x; }
            public double Y() { return y; }
            public Point R(double r)
            {
                x = r * Math.Cos(Phi());
                y = r * Math.Sin(Phi());
                return this;
            }
            public double R()
            {
                return Math.Sqrt(x * x + y * y);
            }
            public double Phi()
            {
                if (x > 0 && y >= 0)
                    return Math.Atan(y / x);
                if (x > 0 && y < 0)
                    return Math.Atan(y / x) + Math.PI * 2;
                if (x < 0)
                    return Math.Atan(y / x) + Math.PI;
                if (x == 0 && y > 0)
                    return Math.PI / 2;
                else
                    return Math.PI * 3.0 / 2;
            }
            public Point Phi(double phi)
            {
                x = R() * Math.Cos(phi);
                y = R() * Math.Sin(phi);
                return this;
            }
            // Private fields
            private double x;
            private double y;
        }
        public void Main_09() // Wrong result TO TEST
        {
            Point point = new Point().X(8.66025).Y(5.0);
            Console.WriteLine("{0} {1} {2} {3}",
                              point.X(), point.Y(),
                              point.R(), point.Phi());
            point.Phi(60.0);
            Console.WriteLine("{0} {1} {2} {3}",
                              point.X(), point.Y(),
                              point.R(), point.Phi());
        }
        class Triangle
        {
            public class Point
            {
                public Point(int x, int y)
                {
                    X = x;
                    Y = y;
                }
                public int X { get; set; }
                public int Y { get; set; }
                public override string ToString()
                {
                    return X + " " + Y;
                }
            }
            public Triangle(Point p1, Point p2, Point p3)
            {
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
            }
            public double Area()
            {
                double a = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
                double b = Math.Sqrt(Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2));
                double c = Math.Sqrt(Math.Pow(p3.X - p2.X, 2) + Math.Pow(p3.Y - p2.Y, 2));
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
            public Point Center()
            {
                return new Point((p1.X + p2.X + p3.X) / 3,
                                 (p1.Y + p2.Y + p3.Y) / 3);
            }
            // Private section
            private Point p1;
            private Point p2;
            private Point p3;
        }
        public void Main_013()
        {
            Triangle triangle = new Triangle(new Triangle.Point(-3, 2),
                                             new Triangle.Point(5, 4),
                                             new Triangle.Point(1, -6));
            Console.WriteLine(triangle.Area());
            Triangle.Point center = triangle.Center();
            Console.WriteLine(center);
        }
    }
}
