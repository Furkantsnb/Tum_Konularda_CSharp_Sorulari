namespace Ornek_2

//Bir Sayının Pozitif Olup Olmadığını Kontrol Eden C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Bir sayı girin");
            i = int.Parse(Console.ReadLine());

            if (i > 0)
                Console.WriteLine("Sayı pozitif");
            else if(i == 0)
                Console.WriteLine("Sayı sayı 0 ra eşit");
            else
                Console.WriteLine("Sayı negatif");

            Console.Read();
        }
    }
}