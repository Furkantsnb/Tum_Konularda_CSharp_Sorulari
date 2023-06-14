namespace Ornek22
//Bir Kişinin Boyunu Kabul Etmek ve Daha Uzun, Cüce ve Ortalama Olarak Sınıflandırmak İçin C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Boyunuzu Girin : ");
            int boy = Convert.ToInt32(Console.ReadLine());

            if (boy > 180)
                Console.WriteLine("Uzun");
            else if (boy > 165 && boy < 180)
                Console.WriteLine("Normal");

            else
                Console.WriteLine("Kısa");

        }
    }
}