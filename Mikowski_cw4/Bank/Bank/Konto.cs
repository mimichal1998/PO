using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Konto
    {
        private string Imie;
        private string Nazwisko;
        private double StanKonta;
        private double SaldoP;
        private double SaldoK;
        List<Konto>Dzialania = new List<Konto>();
        public Konto(string imie,string nazwisko,double stanKonta)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.StanKonta = stanKonta;

        }
        public void Wplata(double kwota)
        {
            this.SaldoP = this.StanKonta;
            this.StanKonta = this.StanKonta + kwota;
            this.SaldoK = this.StanKonta;
            string text = "Wpłata: Saldo Początkowe " + this.SaldoP + " Saldo Końcowe" + this.SaldoK;
            System.IO.File.WriteAllText(@"C:\historiSuko\historia.txt",text);

        }
        public void Saldo()
        {
            Console.WriteLine("stan konta: {0}",this.StanKonta);
        }
    }
}
