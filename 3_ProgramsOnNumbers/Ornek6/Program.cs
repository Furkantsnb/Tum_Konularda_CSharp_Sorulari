namespace Ornek6
//Armstrong Sayısını Kontrol Etmek İçin C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi,basamak,toplam=0;
            Console.Write("Bir sayı girin : ");
            sayi =Convert.ToInt32(Console.ReadLine());

            for(int i = sayi ; i > 0; i= i/10) 
            { 
                basamak = i%10;
                toplam += (int)Math.Pow(basamak, 3);

            }
            if (toplam == sayi)
            {
                Console.WriteLine("Girilen sayi Armstrong sayıdır");
            }
            else
                Console.WriteLine("Girilen sayi Armstrong sayı değildir");

            Console.ReadLine();
        }
    }
}