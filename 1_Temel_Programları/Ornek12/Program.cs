namespace Ornek12
//Bir Sayıyı Tersine Çevirmek ve Palindrom olup olmadığını Kontrol Etmek için C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, gecici, kalan, tersi = 0;

            Console.WriteLine("Bir sayı girin");
            sayi = int .Parse(Console.ReadLine());

            gecici = sayi;
            while(sayi > 0)
            {
                kalan = sayi % 10;
                tersi = tersi*10+kalan;
                sayi /= 10;
            }
            Console.WriteLine("Verilen sayi : " + gecici);
            Console.WriteLine(" Tersi : " +tersi);

            if (tersi == gecici)
                Console.WriteLine("Sayı bir polidromdur.");
            else
                Console.WriteLine("Sayı polidrom değil");
         
        }
    }
}