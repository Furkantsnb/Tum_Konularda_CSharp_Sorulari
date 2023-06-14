namespace Ornek7
//3 ve 5'in Tüm Katlarının Toplamını Bulan C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aralık1, aralık2,toplam=0;
        
            Console.WriteLine("1.aralığı girin");
            aralık1=int.Parse(Console.ReadLine());
            Console.WriteLine("2.aralığı girin");
            aralık2=int.Parse(Console.ReadLine());

            for (; aralık1 <= aralık2; aralık1++)
            {
                if(aralık1%3==0 && aralık1 % 5 == 0)
                {
                     toplam += aralık1;
                } 
            }
            Console.WriteLine("Girilen ikisayı arasında olan 3 ve 5 katlarının toplamı : {0}",toplam);
            Console.Read();
        }
    }
}