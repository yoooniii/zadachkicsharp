using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main(string[] args) {
 List<string> sobstvenici = Console.ReadLine().Split(", ").ToList();
            
            do
            {
                string komandi = Console.ReadLine();
            if (komandi=="END OF OWNERS") break;
                if (komandi=="Add owner")
                {
                    string ime = Console.ReadLine();
                    sobstvenici.Add(ime);
                }
                    if (komandi=="Add owner on position")
                {
                    string ime = Console.ReadLine();
                    int n = int.Parse(Console.ReadLine());
                    sobstvenici.Insert(n, ime);
                }
                if (komandi=="Remove owner on position")
                {
                    int n = int.Parse(Console.ReadLine());
                    sobstvenici.RemoveAt(n);
                }
                if (komandi=="Remove last owner")
                {
                    sobstvenici.RemoveAt(sobstvenici.Count-1);
                }
                if (komandi=="Remove first owner")
                {
                    sobstvenici.RemoveAt(0);
                }
            } while (true);

            Console.WriteLine(string.Join(" ", sobstvenici));
        }
    }
    
    Помогнете на новата ветеринарна клиника да следи за посещенията на собствениците на пациентите си. В системата първоначално има въведени имена на собствениците 
на животните и чрез определени команди можем да добавяме или премахваме имената на собствениците. Команди се получават до достигане на командата END OF OWNERS.
Командите са следните:
Add owner – добавя полученото име накрая на списъка със собствениците
Add owner on position – добавя полученото име на получената позиция
Remove owner on position – премахва името, което е получено, от дадената позиция
Remove last owner – премахва последния собственик от списъка
Remove first owner – премахва първия собственик от списъка
Напишете програма, която при подаден първоначален списък със собственици и команди, принтира обработения списък със собственици.
