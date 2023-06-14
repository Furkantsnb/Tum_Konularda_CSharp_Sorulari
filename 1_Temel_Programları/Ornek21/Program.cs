using System;

namespace Ornek21
    //Küçük Harf Karakterlerini Büyük Harfe ve Tam Tersine Çevirmek için C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;
            int i;
            Console.Write("bir karakter girin : ");
            a = Convert.ToChar(Console.ReadLine());
            i =(int) a;

            if(a>=65 && a <= 90)
            {
            Console.Write("Girdiğiniz karakterin küçük harfe donuşmuş hali : {0} ", char.ToLower(a));
                
            }
            else if (a>=97 && a <= 122)
            {
            Console.WriteLine("Girdiğiniz karakterin büyül harflere donuşmuş hali : {0} ", char.ToUpper(a));

            }
            Console.ReadLine();

        }
    }
}