namespace Ornek_3

//Belirli Bir Aralıkta Tek Sayıları Yazdırmak İçin C# Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> aralık = Enumerable.Range(0, 10).Where(x => x % 2 != 0);

            foreach(int n in aralık)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }
    }
}