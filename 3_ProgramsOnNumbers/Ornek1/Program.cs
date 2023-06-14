namespace Ornek1
//C# ile Fibonacci Dizisi Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sınır, f1 = 0, f2 = 1, f3 = 0; ;
            Console.Write("sınırı girin : "); sınır=int.Parse(Console.ReadLine());
            Console.Write(f1+" ");
            Console.Write(f2+" ");

            for (i = 0; i <= sınır; i++)
            {
                f3 = f1 + f2;
                Console.Write("  "+f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();

        }
    }
}