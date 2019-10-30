using System;

namespace ConsoleApp4
{
    class Car
    {
        private string marka;
        private int rok;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

       
        public Car(string Marka,int Rok, string Model, double PojemnoscSilnika, int IloscDrzwi)
        {
            marka = Marka;
            rok = Rok;
        }
        public string Marka
        {
            get => marka;
            set => marka = value;
        }
        public int Rok
        {
            get => rok;
            set => rok = value;
        }

        public string Model
        {
            get => default(string);
            set
            {
            }
        }

        public double PojemnoscSilnika
        {
            get => default(double);
            set
            {
            }
        }

        public int IloscDrzwi
        {
            get => default(int);
            set
            {
            }
        }
        public double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = dlugoscTrasy * srednieSpalanie;
            return spalanie;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy,double cenaPaliwa)
        {
            double kosztPrzejazdu = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
            return kosztPrzejazdu;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("subaru", 1999,"impreza",3.5,5);
            Console.WriteLine(car1.Marka + " " + car1.Rok);
            /* Car car2 = new Car("bmw", 2004);
             Console.WriteLine(car2.Marka + " " + car2.Rok);
             car1 = car2;
             Console.WriteLine(car1.Marka + " " + car1.Rok);*/
            Console.ReadKey();


        }
    }
}
