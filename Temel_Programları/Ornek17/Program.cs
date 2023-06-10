namespace Ornek17
//Aynı Tabana Sahip Üslerin Bölünmesini Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("taban girin :");
            double taban = double.Parse(Console.ReadLine());
            Console.WriteLine("birinci ussu girin");
            double us1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci ussu girin");
            double us2 = double.Parse(Console.ReadLine());

            double bolum = us1 - us2;
            Console.WriteLine("{0}^{1}={2}", taban, bolum, Math.Pow(taban, bolum));
        }
    }
}