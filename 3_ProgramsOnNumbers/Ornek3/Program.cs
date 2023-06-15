namespace Ornek3
//1'den 100'e Kadar Tüm Asal Sayıları Yazdıran C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool asal = true;
            Console.WriteLine("1'den 100'e Kadar Tüm Asal Sayılar");

            for(int i = 2;i < 100;i++)
            {
                for(int j = 2;j < 100; j++)
                {
                    if(i != j && i % j == 0)
                    {
                        asal = false;
                        break;
                    }
                }
                if(asal)
                {
                    Console.Write("\t"+i);
                }
                asal = true;
            }
            Console.ReadLine();
        }
    }
}