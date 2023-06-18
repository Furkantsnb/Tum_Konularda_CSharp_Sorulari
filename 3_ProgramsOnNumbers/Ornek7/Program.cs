namespace Ornek7
//1 ile 1000 Arası Armstrong Sayısını Yazdıran C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basamak,toplam=0;
            
            Console.WriteLine("1 ile 1000 Arası Armstrong Sayılar ");
            int a,b,c,d;
            for(int i =1;i<=1000;i++)
            {
                a = i / 100;
                b = (i - a * 100) / 10;
                c = (i - a * 100 - b * 10);
                d = a * a * a + b * b * b + c * c * c;

                if (i == d)
                {
                    Console.WriteLine("{0}",i);
                }
             

                
            }
        }
    }
}