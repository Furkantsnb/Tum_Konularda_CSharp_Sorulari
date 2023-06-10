using System.Transactions;

namespace Ornek18
//Özyineleme Kullanarak Bir Tamsayının İkili Eşdeğerini Yazdırmak İçin C# Programı
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            prog pr = new prog();
            Console.WriteLine("Enter a decimal number : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary equvalent of num is : ");
            pr.binaryConversion(num);
            Console.ReadLine();
        }
    }
    public class prog
    {
        public int binaryConversion(int num)
        {
            int bin;
            if(num != 0)
            {
                bin = (num%2) + 10 * binaryConversion(num/2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }
        }
    }

}