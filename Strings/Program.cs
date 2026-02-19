using System.Text;
namespace HomeWork
{
    internal class Program
    {

        //1


        string ConcatenateStrings(string Gold, string Chest)
        {
            return Gold + Chest;
        }

        //2
        string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }

        //3
        string GetStringInfo(string input)
        {
            int length = input.Length;
            string upper = input.ToUpper();
            string lower = input.ToLower();

            return $"Length: {length}; Uppercase: {upper}; Lowercase: {lower}";
        }

        //4
        string GetFirstFiveChars(string qwerty)
        {
            return qwerty.Substring(0, 5);
        }

        //5
        string StringBuilder(string[] words)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var word in words)
            {
                sb.Append(word).Append(" ");
            }
            return sb.ToString();
        }

        //6
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }

        static void Main(string[] args)
        {
            string result = ReplaceWords("Hello world", "world", "universe");

            Console.WriteLine(result);
        }
    }
}

