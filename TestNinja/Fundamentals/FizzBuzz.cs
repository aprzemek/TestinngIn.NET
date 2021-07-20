namespace TestNinja.Fundamentals
{
    public class FizzBuzz
    {
        public static string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0)) //15
                return "FizzBuzz";

            if (number % 3 == 0)    //6
                return "Fizz";

            if (number % 5 == 0) //10
                return "Buzz";

            return number.ToString(); //7
        }
    }
}