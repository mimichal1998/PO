using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Wojownik : bohater
    {
        private int PT;
        private int Sila;
        public Wojownik(string Imie,double Zycie,int pt, int sila) : base(Imie,Zycie)
        {
            imie = Imie;
            zycie = Zycie / 100;
            PT = pt;
            Sila = sila;
        }
        public int pt { get { return PT; } set { PT = value; } }
        public int sila { get { return Sila; } set { Sila = value; } }
        new public double MocAtaku()
        {
            if((zycie*100)<=20)
            {
                return Sila * PT * 1.5;
            }
            else
            {
                return Sila * PT * zycie;
            }
        }
        new public void toString()
        {
            Console.WriteLine("Imie={0} Zycie={1,3:P} Punkty_taktyki={2} Sila={3}",imie,zycie,PT,Sila);
        }
    }
}
