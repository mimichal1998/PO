using System;

namespace Mikowski_cw1
{
    #region my class definition 
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!"); // wypisanie ciągu znaków
            string bob = "bob"; //stworzenie zmiennej typu string z przypisaną do niej wartością
            string eva = "eva";
            Console.WriteLine("Hello" + " " + bob); //wypisanie ciągu znaków i zmiennej
            Console.WriteLine("Hello" + " " + eva);
            Console.WriteLine("Podaj imie:");
            string userName = Console.ReadLine(); //wczytanie ciągu znaków do zmiennej 
            Console.WriteLine("Hello " + userName);

            

            int a = 2;
            int b = 3;
            Console.WriteLine("dodawanie:"+ (a+b));
            Console.WriteLine("odejmowanie:"+ (a-b));
            Console.WriteLine("mnożenie:"+(a*b));
            Console.WriteLine("dzielenie:"+(a/b));
            bool logiczna = true;
            Console.WriteLine(logiczna);
            Console.WriteLine(!logiczna);

            Console.WriteLine(a==b);
            Console.WriteLine(a<b);
            Console.WriteLine(a>b);
            Console.WriteLine(a!=b);
            Console.WriteLine(a&b);
            Console.WriteLine(a|b);

            int c = 1;
            c++;
            c--;

            */
            //autorem kodu jest Michał Mikowski

            /*cw 1
             * 
            int[] tab = { 1, 2, 3, 4, 5, 6 };
            for(int i =0;i<tab.Length;i++)
            {
                Console.Write(tab[i]+",");
            }
            for(int i = 0;i<tab.Length;i++)
            {
                Console.WriteLine(tab[i]);
            }
            for(int i = tab.Length - 1;0<=i;i--)
            {
                Console.WriteLine(tab[i]);
            }
            */

            /*cw 2
             * 
             * 
            Console.WriteLine("Podaj przyprostokątną 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przyprostokątną 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przeciwprostokątną:");
            int c = int.Parse(Console.ReadLine());
            
            if(((a+b)>c) && ((a+c)>b) && ((c+b)>a))
            {
                Console.WriteLine("trojkat istnieje");
            }
            else
            {
                Console.WriteLine("trojkat nie istnieje");
            }*/


            /* cw3
             * 
             * 
            Console.WriteLine("podaj liczbe");
            int i = int.Parse(Console.ReadLine());
            while(i<=5 || i>=15)
                {
                Console.WriteLine("podaj liczbe");
                i = int.Parse(Console.ReadLine());
                }
            while(i!=0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine(i);*/
            Console.WriteLine("Podaj liczbę >4,<7,!=6");
            int i = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Podaj liczbę >4,<7,!=6");
                i = int.Parse(Console.ReadLine());
            }
            while (i < 4 || i > 7 || i == 6);
            Console.ReadKey();
        }
    }
    #endregion
}
