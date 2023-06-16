namespace Ornek4
//Bir Sayının En Büyük Asal Faktörünü Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int k = 0;
            Console.Write("Bir sayi girin : "); sayi = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= sayi; i++)
            {
                if(sayi % i == 0)
                {
                    k++;
                }
            }

            if (k == 2)
                    Console.WriteLine("Girilen sayı asal sayıdır ve En büyük çarpan {0}'dır",sayi);

            else
                Console.WriteLine("Girilen sayı asal değildir.");
            
        }
    }
}