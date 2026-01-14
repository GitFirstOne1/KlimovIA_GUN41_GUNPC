internal class Program
{
    private static void Main(string[] args)
    {
        if (!Int32.TryParse(Console.ReadLine(), out var a))

            Console.WriteLine("Not a number!");
        

        if (!Int32.TryParse(Console.ReadLine(), out var b))

            Console.WriteLine("Not a number!");
        

        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)

            Console.WriteLine("Wrong sign");
        

        switch (s[0])
        {
            case '&':
                Console.WriteLine("Result of {0} & {1} = {2}", a, b, Convert.ToString(a & b,2));
                Console.WriteLine("Result of {0} & {1} = {2}", a, b, Convert.ToString(a & b,10));
                Console.WriteLine("Result of {0} & {1} = {2}", a, b, Convert.ToString(a & b,16));
                break;

            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, Convert.ToString(a | b,2));
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, Convert.ToString(a | b,10));
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, Convert.ToString(a | b,16));
                break;

            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b,2));
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b,10));
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b,16));
                break;
            
            default:
                Console.WriteLine("Wrong sign");
                break;
        }
    }
}