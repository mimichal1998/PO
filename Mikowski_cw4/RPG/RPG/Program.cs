using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Lucznik Legolas = new Lucznik("Legolas",50,3,20);
            Wojownik Smigol = new Wojownik("Smigol",20,1,2000);

            Legolas.toString();
            Smigol.toString();
            Console.WriteLine(Smigol.MocAtaku());
            Smigol.ZmianaPZ(100);
            Smigol.toString();
            Console.ReadKey();

        }
    }
}   
