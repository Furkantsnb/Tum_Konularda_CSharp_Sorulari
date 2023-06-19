namespace Ornek11
    //Bir Sayının Mutlak Değerini Yazdırmak İçin C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayı girin : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayının mutlak değeri : {0}",Math.Abs(sayi));

            //2. Yol
            if (sayi < 0)
            {
                sayi = sayi * (-1);
            }
            Console.WriteLine("Girilen sayının mutlak değeri : {0}",sayi);

        }
    }
}