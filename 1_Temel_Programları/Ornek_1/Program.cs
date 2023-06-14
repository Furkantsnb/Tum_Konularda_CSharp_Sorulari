namespace Ornek_1

//Verilen Bir Sayının Çift mi Tek mi Olduğunu Kontrol Eden C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Bir sayı girin");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
                Console.WriteLine("Girilen sayı çiftir.");

            else
                Console.WriteLine("Girilen sayı tektir.");

            Console.Read();
        }
    }
}