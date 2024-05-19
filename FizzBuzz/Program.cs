namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzService();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzzService.GetResult(i));
            }
        }
    }
}
