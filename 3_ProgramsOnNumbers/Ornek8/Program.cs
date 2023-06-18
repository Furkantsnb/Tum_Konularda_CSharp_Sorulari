namespace Ornek8
//N Sayının Toplamını Oluşturan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç tane sayı gireceksiniz : ");
            int n = int.Parse(Console.ReadLine());
            int toplam = 0;
            for(int i = 1; i <=n; i++)
            {
                Console.Write("{0}. Sayıyı girin : ",i);
                int sayi = int.Parse(Console.ReadLine());   

                toplam += sayi;
            }
            Console.WriteLine("Girilen sayıların toplamı : {0}",toplam);
            Console.ReadLine();
        }
    }
}