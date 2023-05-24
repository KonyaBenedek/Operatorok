using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operátorok
{   
    public class Operator
    {
        int aOperand;
        int bOperand;
        string operat;

        public int AOperand { get => aOperand; set => aOperand = value; }
        public int BOperand { get => bOperand; set => bOperand = value; }
        public string Operat { get => operat; set => operat = value; }

        public Operator(string sor) 
        {
            string[] adatok = sor.Split(' ');
            aOperand = int.Parse(adatok[0].Trim());
            operat = adatok[1].Trim();
            bOperand = int.Parse(adatok[2].Trim());
            
        }   
    }
}
