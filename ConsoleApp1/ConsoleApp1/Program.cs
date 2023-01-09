namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine();

            byte[] array = File.ReadAllBytes("../../../file.txt");

            foreach(var x in array)
            {
                Console.Write(Convert.ToString(x,16)+"-");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}