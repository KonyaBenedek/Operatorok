using System;
using System.IO;
using System.Linq;
using Operátorok;
using System.Text;

namespace Operátorok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Operator> operatorok = new List<Operator>();

            StreamReader sw = new StreamReader("kifejezesek.txt", Encoding.UTF8);

            while (!sw.EndOfStream)
            {
                operatorok.Add(new Operator(sw.ReadLine()));
            }
            sw.Close();

            Console.WriteLine($"2. feladat: Kifejezések száma: {operatorok.Count}");

            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {operatorok.Count(x=> x.Operat == "mod")}");

            int index = 0;
            bool vanIlyen = false;
            while (!vanIlyen)
            {
                vanIlyen = operatorok[index].AOperand % 10 == 0 && operatorok[index].BOperand % 10 == 0;
                index++;
            }
            
            Console.WriteLine($"4. feladat: {(vanIlyen ? "Van" : "Nincs")} ilyen kifejezés!");

            Console.WriteLine("5. feladat: Statisztika");
            operatorok.Where(x => x.Operat == "+" || x.Operat == "-" || x.Operat == "*" || x.Operat == "/" || x.Operat == "div" || x.Operat == "mod").GroupBy(x => x.Operat).ToList().ForEach(y => Console.WriteLine($"{y.Key} -> {y.Count()} db"));
        }
    }
}