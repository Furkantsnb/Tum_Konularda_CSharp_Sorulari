namespace Ornek_4
//İki Sayıdan En Büyüğünü Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("1. sayyıyı girin");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayyıyı girin");
            sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2)
                Console.WriteLine("{0} En büyük sayıdır.", sayi1);

            else if (sayi1 == sayi2)
                Console.WriteLine("iki sayı birbirine eşit");

            else
                Console.WriteLine("{0} en büyük sayıdır.",sayi2);

            Console.Read();
        }
    }
}