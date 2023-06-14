namespace Ornek2
//Maksimum Veri Türü Aralığını Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Maximum Range of the Decimal " +
                              "Data Type is : {0} ", Decimal.MaxValue);
            Console.WriteLine("The Maximum Range of the Float " +
                              "Data Type is : {0} ", Single.MaxValue);
            Console.WriteLine("The Maximum Range of the Decimal " +
                              "Data Type is : {0} ", Double.MaxValue);
            Console.WriteLine("Exponent Form : The Maximum Range of Decimal " +
                              "Data Type  is : {0:E}", Decimal.MaxValue);
            Console.WriteLine("Exponent Form : The Maximum Range of Float " +
                              "Data Type  is : {0:E}", Single.MaxValue);
            Console.WriteLine("Exponent Form : The Maximum Range of Double " +
                              "Data Type  is : {0:E}", Double.MaxValue);
            Console.ReadLine();
        }
    }
}