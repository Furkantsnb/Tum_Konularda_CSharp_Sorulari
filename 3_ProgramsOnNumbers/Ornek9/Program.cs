namespace Ornek9
//For Döngüsü Kullanarak İlk 50 Doğal Sayının Toplamını Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            
            for (int i = 0; i < 50; i++)
            {
                toplam += i;
            }
            Console.Write("İlk 50 Doğal Sayının Toplamı : {0}",toplam);
            Console.ReadLine();
        }
    }
}