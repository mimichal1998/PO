using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class bohater
    {
        private string Imie;
        private double Zycie;
        
        public bohater(string imie,double zycie)
        {
            Imie = imie;
            Zycie = zycie / 100;

        }
        public string imie { get { return Imie; } set { Imie = value; } }
        public double zycie { get { return Zycie; } set { Zycie = value; } }
        public void ZmianaPZ(double nowePZ)
        {
            if (nowePZ >= 0 || nowePZ <=100)
            {
                Zycie = nowePZ / 100;
            }
            
        }
        public double MocAtaku()
        {
            return Zycie;
        }
        public void toString()
        {
            Console.WriteLine("Imie={0} Zycie={1,3:P}",Imie,Zycie);
        }
    }
}
