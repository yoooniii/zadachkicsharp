namespace itkariera1
{
    internal class Program
    {
static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            butterfly(n);
        }
        static void rowOne (int stars, string middle)
        {
            for (int i = 0; i < stars; i++) Console.Write("*");
            Console.Write(middle);
            for (int i = 0; i < stars; i++) Console.Write("*");
            Console.WriteLine();
        }
        static void mid(int spaces)
        {
            for (int i = 0; i < spaces; i++) Console.Write("");
            Console.WriteLine("@");
        }
        static void rowTwo(int hyphens, string middle)
        {
            for (int i = 0; i < hyphens; i++) Console.Write("-");
            Console.Write(middle);
            for (int i = 0; i < hyphens; i++) Console.Write("-");
            Console.WriteLine();
        }
        static void butterfly (int n)
        {
            bool f = false;
            for (int i = 0; i < n - 2; i++)
            {
                if (f) rowTwo(n - 2, "\\ /");
                else rowOne(n - 2, "\\ /");
                f = !f;
            }
            mid(n - 1);
            f = false;
            for (int i = 0; i < n - 2; i++)
            {
                if (f) rowTwo(n - 2, "/ \\");
                else rowOne(n - 2, "/ \\");
                f = !f;
            }
        }
        }
        }
