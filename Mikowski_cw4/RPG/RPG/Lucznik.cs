using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Lucznik: bohater
    {
        private int PT;
        private int Zrecznosc;
        public Lucznik(string Imie,double Zycie, int pt, int zrecznosc):base(Imie,Zycie)
        {
            imie = Imie;
            zycie = Zycie / 100;
            PT = pt;
            Zrecznosc = zrecznosc;
        }
        public int pt { get { return PT; } set { PT = value; } }
        public int zrecznosc { get { return Zrecznosc; } set { Zrecznosc = value; } }
        new public double MocAtaku()
        {
            return Zrecznosc * PT * zycie;
        }
        new public void toString()
        {
            Console.WriteLine("Imie={0} Zycie={1,3:P} Punkty_taktyki={2} ={3}", imie, zycie, PT, Zrecznosc);
        }
    }
}
