namespace Ornek16
//Aynı Tabana Sahip Üslerin Çarpımını Gerçekleştiren C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Taban girin : ");
            double sayi = double.Parse(Console.ReadLine());
            Console.Write("birinci üssü girin : ");
            double ust1 = double.Parse(Console.ReadLine());
            Console.Write("İkinci üssü girin : ");
            double ust2 = double.Parse(Console.ReadLine()); 

            double kat = ust1 + ust2;

            Console.Write("girilen ustlerin sonucu : {0}^{1}={2}",sayi,kat,Math.Pow(sayi,kat) );
            Console.ReadLine();
        }
    }
}