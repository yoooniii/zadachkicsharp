using System;

namespace zadachi 
{
    class Program
    {
//                                           magicheski chisla (naistina nqmam ideq kakvo e uslovieto)

          static void Main(string[] args)
          {
              int n = int.Parse(Console.ReadLine());
              for (int a = 1; a < 10; a++)
                  for (int b = 1; b < 10; b++)
                      for (int c = 1; c < 10; c++)
                          for (int d = 1; d < 10; d++)
                              for (int e = 1; e < 10; e++)
                                  for (int f = 1; f < 10; f++)
                                      if (a * b * c * d * e * f == n) { 
                                        Console.WriteLine(f+10*e+100*d+1000*c+10000*b+100000*a);
              Console.WriteLine("{0}{1}{2}{3}{4}{5}", a, b, c, d, e, f);
                                      }
              }
              }
              }
