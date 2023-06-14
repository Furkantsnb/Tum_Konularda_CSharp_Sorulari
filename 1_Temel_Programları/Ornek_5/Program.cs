namespace Ornek_5
//İki Sayının Yerini Değiştirmek İçin C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2,atama;

            Console.WriteLine("1. Sayıyı girin");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı girin");
            sayi2 = int.Parse(Console.ReadLine());

            atama = sayi1;
            sayi1 = sayi2;
            sayi2 = atama;
            Console.WriteLine("sayılar yer değiştikten sonra");
            Console.WriteLine("ilk sayi : " + sayi1);
            Console.WriteLine("ikinci sayi : " + sayi2);

            Console.Read();
        }
    }
}