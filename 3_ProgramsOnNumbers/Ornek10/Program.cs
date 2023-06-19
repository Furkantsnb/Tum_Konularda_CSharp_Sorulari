namespace Ornek10
//Verilen Sayının Çarpanlarını Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayı girin : "); sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girilen sayının çarpanları");
            for(int i = 1; i <= sayi; i++)
            {
                if(sayi%i== 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();

        }
    }
}