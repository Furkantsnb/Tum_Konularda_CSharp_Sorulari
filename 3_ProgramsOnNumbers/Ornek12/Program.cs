namespace Ornek12
//Rastgele Sayılar Üretmek için C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üretilen bazı raskele sayılar :");

            for(int i = 1;i <= 10;i++)
            {
              
               Randfunc();
               

            }
        }

        static Random r = new Random();
        static void Randfunc()
        {
            int n = r.Next();
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}