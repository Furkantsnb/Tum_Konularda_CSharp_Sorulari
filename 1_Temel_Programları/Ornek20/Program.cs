namespace Ornek20
//Bir Notu Okumak ve Eşdeğer Açıklamayı Görüntülemek için C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Notunuzu Girin : ");
            char not = Convert.ToChar(Console.ReadLine());

            switch (not)
            {
                case 'A':
                    Console.Out.WriteLine("Süper");
                    break;
                case 'B':
                    Console.Out.WriteLine("iyi");
                    break;

                case 'C':
                    Console.Out.WriteLine("orta");
                    break;
                case 'D':
                    Console.Out.WriteLine("kotu");
                    break;
                default:
                    Console.Out.WriteLine("Geçersiz işlem");
                    break;

            }
            Console.ReadLine();
        }
    }
}