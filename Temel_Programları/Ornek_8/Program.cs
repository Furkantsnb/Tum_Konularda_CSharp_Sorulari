namespace Ornek_8
//17'nin 100'den Küçük Tüm Katlarını Yazdırmak İçin C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17'nin katları:");
          for (int i = 17; i < 100; i++)
            {
                if (i % 17 == 0)
                    Console.WriteLine(i);
                
                    
                       
            }
         
        }
    }
}