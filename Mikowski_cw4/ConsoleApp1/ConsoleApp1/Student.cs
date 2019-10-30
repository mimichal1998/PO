using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student : Osoba
    {
        public int Rok {get; set;}
        public int NumerGrupy { get; set; }
        public int NumerAlbumu { get; set; }

        public Student(string imie,string nazwisko,int rokUrodzenia,string miejsceZamieszkania,int rok,int numerGrupy,int numerAlbumu) : base(imie, nazwisko,rokUrodzenia,miejsceZamieszkania)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            RokUrodzenia = rokUrodzenia;
            MiejsceZamieszkania = miejsceZamieszkania;
            Rok = rok;
            NumerGrupy = numerGrupy;
            NumerAlbumu = numerAlbumu;
        }
    new public void wypiszInfo()
        {
            Console.WriteLine(this.Imie + " " + this.Nazwisko + " " + this.RokUrodzenia + " " + this.MiejsceZamieszkania + " " + this.Rok + " " + this.NumerGrupy + " " + this.NumerAlbumu);
            Console.ReadKey();
        }
    }
}
