namespace Ornek13
//İki Binary Sayının Toplamını Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0, b1, b2, kalan = 0;
            int[] toplam = new int[20];
            Console.Write("Birinci sayiyi girin : ");
            b1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayiyi girin : ");
            b2 = int.Parse(Console.ReadLine());

            while (b1 != 0 || b2 != 0)
            {
                toplam[i++] = (b1 % 10 + b2 % 10 + kalan)%2;
                kalan = (b1 % 10 + b2 % 10 + kalan)/2;
                b1= b1/10; 
                b2 = b2/10;

            }
            if(kalan != 0)
            {
                toplam[i++] = kalan;
                i--;
                Console.Write("iki binary sayının toplamı : ");
                while (i >= 0)
                    Console.Write("{0}", toplam[i--]);

                Console.ReadLine();

            }
        }
    }
}