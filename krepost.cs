using System;

namespace zadachi
{
    class Program
    {
//                                                  zamuk (krepost)
            static void castle1(int circumflexes, int underscores)
            {   Console.Write("/");
                for (int i = 0; i < circumflexes; i++) Console.Write("^");      
                Console.Write("\\");
            for (int i = 0; i < underscores; i++) Console.Write("_");
                Console.Write("/");
                for (int i = 0; i < circumflexes; i++) Console.Write("^");
                Console.WriteLine("\\");
            }
            static void castle2 (int spaces)
            {   Console.Write("|");
                for (int i = 0; i < spaces; i++) Console.Write(" ");
                Console.WriteLine("|");
            }
            static void castle3(int spaces, int underscores)
            {   Console.Write("|");
                for (int i = 0; i < spaces; i++) Console.Write(" ");
                for (int i = 0; i < underscores; i++) Console.Write("_");
                for (int i = 0; i < spaces; i++) Console.Write(" ");
                Console.WriteLine("|");
            }
            static void castles4(int underscores, int spaces)
            {   Console.Write("\\");
                for (int i = 0; i < underscores; i++) Console.Write("_");
                Console.Write("/");
                for (int i = 0; i < spaces; i++) Console.Write(" ");
                 Console.Write("\\");
                for (int i = 0; i < underscores; i++) Console.Write("_");
                Console.Write("/");  
            }
            static void castle(int n)
            {
                castle1(n / 2,2*n-2*(n/2+2));
                for (int i = 0; i < n - 2; i++) castle2(2 * n - 2);
                if (n>4) castle3(n / 2+1, 2 * n - 2 * (n / 2 +2));
                castles4(n / 2, 2 * n - 2 * (n / 2 +2));
            }
            static void Main(string[] args)
            {
                do
                {
                    int n = int.Parse(Console.ReadLine());
                    castle(n);
                }
                while (true);
            }
            }
            }
