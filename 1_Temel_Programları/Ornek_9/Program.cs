namespace Ornek_9
    //Bir Sayının Rakamlarının Toplamını Bulan C# Programı
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sayi, toplam = 0, x;
            Console.Write("Bir sayı girin : ");
            sayi = int.Parse(Console.ReadLine());

            while(sayi != 0)
            {
                x = sayi % 10;
                sayi=sayi / 10;
                toplam += x;
            }
            Console.WriteLine("girilen sayının rakamlar toplamı : " + toplam);
            Console.Read();
        }
    }
}