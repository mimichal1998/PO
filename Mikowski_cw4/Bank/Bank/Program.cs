using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto A = new Konto("Marian", "Tomniewkurwia", 10000);
            A.Wplata(500);
            A.Saldo();
        }
    }
}
