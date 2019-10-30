using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int RokUrodzenia { get; set; }
        private string miejsceZamieszkania;
        public Osoba(string imie,string nazwisko ,int rokUrodzenia,string miejsceZamieszkania)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            RokUrodzenia = rokUrodzenia;
            MiejsceZamieszkania = miejsceZamieszkania;
        }
        public string MiejsceZamieszkania {  get{ return miejsceZamieszkania; }  set{ miejsceZamieszkania = value; } }
        public void wypiszInfo()
        {
            Console.WriteLine(this.Imie + " " + this.Nazwisko + " " + this.RokUrodzenia);
            Console.ReadKey();
        }
        public int ObliczWiek()
        {
            int wiek = 2019 - RokUrodzenia;
            return wiek;
        }
    }
}
