namespace Ornek4
//Koşullu Mantıksal Operatörün kullanımını Gösteren C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("yaşınızı girin : ");
            int yas = int.Parse(Console.ReadLine());
            bool yetiskin = yas >= 18? true: false;
            Console.WriteLine("yetişkin : {0}",yetiskin);
            Console.ReadLine();
        }
    }
}