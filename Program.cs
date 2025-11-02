namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Из двоичной системы в десятичную");
            string BinToDec = Console.ReadLine();
            Console.WriteLine(Convert.ToByte(BinToDec, 2));

            Console.WriteLine("Из десятичной системы в двоичную");
            int DecToBin = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(DecToBin, 2));

            Console.WriteLine("Введите N - часов");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите M - минут");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите T - через сколько минут");
            int T = int.Parse(Console.ReadLine());
            Console.WriteLine($"В {Convert.ToDateTime($"{N}:{M}").AddMinutes(T).ToShortTimeString()} привезут продукты");

        }
    }
}
