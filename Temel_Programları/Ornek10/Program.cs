namespace Ornek_10
//Özyineleme Kullanarak Bir Sayının Rakamlarının Toplamını Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc;
            pro pg = new pro();
            Console.Write(" Bir sayı girin : ");
            sayi = int.Parse(Console.ReadLine());
            sonuc = pg.toplam(sayi);
            Console.WriteLine("{0} rakamlarının toplamı : {1} ", sayi, sonuc);
            Console.ReadLine();
            
        }
    }
    class pro
    {
        public int toplam(int sayi)
        {
            if(sayi !=0)
                return (sayi%10 + toplam(sayi/10));

            else
                return 0;
        }
    }
}