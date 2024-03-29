using System;
using System.Collections.Generic;
using System.Linq;
namespace spisuk{
public class Program {
    public static void Main(string[] args) {
string s = Console.ReadLine();

Dictionary<char,int> kolkochr = new Dictionary<char,int>();
for (int i = 0; i < s.Length; i++)
{
char c = s[i];
if (char.IsWhiteSpace(c)) { continue; }
if (!kolkochr.ContainsKey(c)) { kolkochr[c] = 1; }
else { kolkochr[c]++; }
}
var br = kolkochr.OrderBy(a => s.IndexOf(a.Key));
foreach (var a in br)
{
Console.WriteLine(a.Key + " -> " + a.Value);
}
}
    }
}

Напишете програма, която брои символите в дадения текст от конзолата, с изключение на символа интервал
Принтирайте символа и броя на срещанията му в следния формат:
"{символ} -> {брой срещания}"
