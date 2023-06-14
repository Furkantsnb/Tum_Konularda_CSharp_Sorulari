namespace Ornek6
//Bir Sayının 2'ye Bölünebilir Olup Olmadığını Kontrol Eden C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Sayi girin");
            sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine("Girilen sayı ikiye bölünebilir.");
            else
                Console.WriteLine("Girilen sayi ikiye bölünmez");

            Console.Read();
        }
    }
}