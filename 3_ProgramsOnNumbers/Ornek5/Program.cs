namespace Ornek5
//Verilen Bir Sayının Mükemmel Sayı Olup Olmadığını Kontrol Eden C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam = 0, n;
            Console.Write("Bir sayi girin : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            n = sayi;
            for(int i = 1; i < sayi; i++)
            {
                if(sayi%i == 0)
                {
                    toplam += i;
                }
            }
            if (toplam == n)
            {
                Console.WriteLine("Girilen sayi mükemmel sayidir.");
            }
            else
                Console.WriteLine("Girilen sayı mükemmel sayı değildir.");

            Console.ReadLine();
        }
    }
}