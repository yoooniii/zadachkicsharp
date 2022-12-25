  namespace itkariera1
{
    internal class Program
    {
  static void action(char from, char to)
        {
            Console.WriteLine("take from {0}, put on {1}", from, to);
        }
        static void hanoi(int n, char from,char to, char used)
        {
            if (n == 1) { action(from, to);
                return;
            }
            hanoi(n - 1, from, used, to);
            action(from, to);
            hanoi(n - 1, used, to, from);
        }
        static void main(string[] args)
        {
            hanoi(3, 'a','c','b');
        }
}
 }
