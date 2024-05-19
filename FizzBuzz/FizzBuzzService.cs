namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public string GetResult(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            return number.ToString();
        }
    }
}
