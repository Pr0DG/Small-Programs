using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
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
            Console.WriteLine((new Byte()).set(0).set(2).set(5).get());
            Console.ReadKey();
        }
        class Byte
        {
            private bool[] b = new bool[8];
            public int get()
            {
                int sum = 0;
                for (int index = 0; index < 8; ++index)
                    sum += (b[index]) ? (int)Math.Pow(2.0, (7 - index)) : 0;
                return sum;
            }
            public Byte set(int n)
            {
                b[7 - n] = true;
                Byte newB = new Byte();
                newB.b = b;
                return newB;
            }
        }
    }
}
