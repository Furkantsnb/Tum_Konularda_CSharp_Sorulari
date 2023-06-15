namespace Ornek2
//Belirli Bir Sayının Faktöriyelini Yazdırmak İçin C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, faktoriyel = 1;
            Console.Write("sayi girin : ");
            sayi = int.Parse(Console.ReadLine());

            for(int i = 1; i <=sayi; i++)
            {
                faktoriyel *=i;
            }
            Console.Write("Girilen sayının faktoriyeli : {0}",faktoriyel);
        }
    }
}