namespace Ornek15
//Tüm Aritmetik İşlemleri Gerçekleştiren C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc = 0;
            char giris;
           

            while (true)
            {
                
                Console.WriteLine("1. Toplama ");
                Console.WriteLine("2. Cikarma  ");
                Console.WriteLine("3. Carpma  ");
                Console.WriteLine("4. Bolme  ");
                Console.WriteLine("5. çıkış  ");
                Console.Write("işlemlerden birini seçin :");
                giris = Convert.ToChar(Console.ReadLine());

                if (giris == '5')
                    break;
                else
                {
                    Console.WriteLine("1. sayiyi girin : ");
                    sayi1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("2. sayiyi girin : ");
                    sayi2 = int.Parse(Console.ReadLine());



                    switch (giris)
                    {
                        case '1':
                            sonuc = sayi1 + sayi2;
                            Console.WriteLine(" iki sayinin toplamı : {0}", sonuc);
                            break;
                        case '2':
                            sonuc = sayi1 - sayi2;
                            Console.WriteLine(" iki sayinin farki: {0}", sonuc);
                            break;
                        case '3':
                            sonuc = sayi1 * sayi2;
                            Console.WriteLine("iki saiyinin carpimi : {0}", sonuc);
                            break;
                        case '4':
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("iki sayinin bolumu : {0}", sonuc);
                            break;


                    }
                }


            }
                Console.WriteLine("İşlemlerden cikiliyor...  ");
        }
    }
}