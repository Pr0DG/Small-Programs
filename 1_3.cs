using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void o1_3_1() {
            double kelvTemp, celsTemp, rankTemp, reaumTemp;
            kelvTemp = Double.Parse(Console.ReadLine());
            celsTemp = kelvTemp - 273.15;
            rankTemp = 9 / 5.0 * kelvTemp;
            reaumTemp = 4 / 5.0 * celsTemp;
            Console.WriteLine(celsTemp + " " + rankTemp + " " + reaumTemp);
        }
        private static void o1_3_2() {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            Console.WriteLine(a + b > c && a + c > b && b + c > a);
        }
        private static void o1_3_3() {
            int hour, minute;
            string[] tokens = Console.ReadLine().Split();
            hour = Convert.ToInt32(tokens[0]);
            minute = Convert.ToInt32(tokens[1]);
            Console.WriteLine(hour == 10 && minute >= 30 || hour == 18 && minute <= 30 
                              || hour > 10 && hour < 18);
        }
        private static void o1_3_14() {
            string[] tokens = Console.ReadLine().Split();
            int sum = 0, total = 0; 
            for (int i = 0; i < tokens.Length+2; ++i) {
                total += i;
                if (i >= tokens.Length) continue;
                sum += int.Parse(tokens[i]);
            }
            Console.WriteLine(total - sum);
        }
        private static void o1_3_15() {
            string[] tokens = Console.ReadLine().Split();
            int numberOfOnes = 0, total = 0;
            for (int i = 0; i < tokens.Length; ++i) {
                if (int.Parse(tokens[i]) == 1)
                    ++numberOfOnes;
                else
                    total += numberOfOnes;
            }
            Console.WriteLine(total);
        }
        private static void o1_3_16() {
        // I couldn't find solution for one repeat loop on standard input. Left as 'todo' 
        }
        private static void o1_3_7() {
            double bmi, weight, height;
            string[] tokens = Console.ReadLine().Split();
            weight = Convert.ToDouble(tokens[0]);
            height = Convert.ToDouble(tokens[1]);
            height /= 100;
            bmi = weight / (height * height);
            Console.WriteLine(bmi);
            if (bmi < 18.5)
                Console.WriteLine("underweight");
            else if (bmi >= 18.5 && bmi < 25)
                Console.WriteLine("norm");
            else if (bmi >= 25 && bmi < 30)
                Console.WriteLine("overweight");
            else
                Console.WriteLine("obesity");
        }
        private static void o1_3_10() {
            int number = Convert.ToInt32(Console.ReadLine());
            while(number != 1) {
                Console.Write(number + " ");
                number = (number % 2 == 0) ? number / 2 : number * 3 + 1;
            }
            if (number == 1)
                Console.Write(1);
        }
        private static void o1_3_9() {
            string[] numbersAsWords = {"zero", "one", "two", "three", "four", "five",
                                       "six", "seven", "eight", "nine", "ten"};
            int input = Convert.ToInt32(Console.ReadLine());
            for (; input >= 0; --input)
                Console.Write(numbersAsWords[input] + " ");
        }
        static void Main(string[] args) {
            o1_3_9();
        }
    }
}
 