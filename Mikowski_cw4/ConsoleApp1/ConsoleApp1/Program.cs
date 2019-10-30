using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Michał", "Mikowski", 1998,"Giżycko",2,2,150807);
            Student student2 = new Student("k", "k", 34643,"d",2,2,115267);
            Osoba osoba1 = new Osoba("katarzyna", "kuś", 31111,"daleko");
            Osoba osoba2 = new Osoba("Andrzej", "Mały", 2222,"blisko");
            Student osoba1 = new Student();
            Console.ReadKey();
        }
    }
}
