using System;

namespace _2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Application()).run();
            Console.ReadKey();
        }
    }
    class Application
    {
        public void run()
        {
            main_2_3_9();
        }
        private void main_2_3_1()
        {
            double small=0, large=0;
            clock(ref small, ref large, 13, 23);
            Console.WriteLine("{0} {1}", small, large);
        }
        private void clock(ref double small, ref double large, int hour, int minute)
        {
            small = (hour % 12 + minute / 60.0) / 12.0  * 360; 
            large = minute / 60.0 * 360;
        }
        private void main_2_3_2()
        {
            int degrees=0, minutes=0, seconds=0;
            dms(ref degrees, ref minutes, ref seconds, 123.37);
            Console.WriteLine($"{degrees} {minutes} {seconds}");
        }
        private void dms(ref int degrees, ref int minutes, ref int seconds, double decDegrees)
        {
            degrees = (int)decDegrees;
            minutes = (int)(60.0*(decDegrees  - degrees));
            seconds = (int)(3600.0 * (decDegrees - degrees) - 60 * minutes);
        }
        private void main_2_3_3()
        {
            double integral = 0, fractional = 0;
            fraction(ref integral, ref fractional, 3.14159);
            Console.WriteLine($"{integral} {fractional}");
        }
        private void fraction(ref double integral, ref double fractional, double number)
        {
            integral = (int)number;
            fractional = number - integral;
        }
        private void main_2_3_4()
        {
            double x1=0, x2=0, delta = quadratic(ref x1,ref x2, 2, -7, -15);
            Console.WriteLine(delta);
            if (0.0 <= delta)
                Console.WriteLine($"{x1} {x2}");
        }
        private double quadratic(ref double x1, ref double x2, int a, int b, int c)
        {
            double delta = b * b - 4 * a * c;
            if(delta >= 0) {
                x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            }
            return delta;
        }
        private void main_2_3_5()
        {
            int a = 60, b = 1240;
            euclid(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }
        private void euclid(ref int a, ref int b)
        {
            int tmpA = a, tmpB = b;
            while (a != b) 
                if (a > b)
                    a -= b;
                else
                    b -= a;
            b = tmpA * tmpB / a;
        }
        private void main_2_3_6()
        {
            double a = 2.71828, b = exchange(ref a, 3.14159);
            Console.WriteLine($"{a} {b}");
        }
        private double exchange(ref double a, double x)
        {
            double tmp = a;
            a = x;
            return tmp; 
        }
        private void main_2_3_7()
        {
            double a = 2.71828, b = 3.14159;
            swap(ref a, ref b);
            Console.WriteLine($"{a} {b}");
        }
        private void swap(ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp; 
        }
        private void main_2_3_8()
        {
            double a = 2.3, b = 3.2;
            choose(ref a, ref b, false) = 10.9;
            Console.WriteLine($"{a} {b}");
        }
        private ref double choose(ref double a, ref double b, bool x)
        {
            if (x) return ref a;
            return ref b;
        }
        private void main_2_3_9()
        {
            rng() = 7;
            for (int counter = 0; counter < 10; ++counter)
                Console.Write(rng() + " ");
            Console.WriteLine();
        }
        private ref int rng()
        {
            //static int x = (33*x+1)%1024;
            //return x;
            //There's a problem with static type of C#. It doesn't work the same as in C++.
            //Problem needs to wait for solution. I'll do it soon.
        }
    }
}
