namespace Ornek19
//Çarpım tablosunu yazdırmak için C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir sayi girin");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi <= 0)
            {
                Console.WriteLine("Geçersiz bir sayi girdiniz");
                Console.Write("Sıfırdan büyük bir sayı girin");
                sayi= Convert.ToInt32(Console.ReadLine());  
            }
            Console.WriteLine("Çarpım tablosu : ");
            for(int i=1; i<sayi; i++)
            {
                Console.WriteLine("\n");
                for (int j =1; j<sayi; j++)
                {
                    Console.WriteLine("{0}*{1} = {2}",i,j,i*j);
                    

                }
               
            }
            Console.ReadLine();
        }
    }
}