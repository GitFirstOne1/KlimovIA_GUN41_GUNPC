// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using System.Transactions;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEnter № task (1-3) or 'exit'");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "exit") break;

                switch (choice)
                {
                    case "1": new NOne().TaskLoop(); break;
                    case "2": new NTwo().TaskLoop(); break;
                    case "3": new NThree().TaskLoop(); break;
                    default: Console.WriteLine("Incorrect."); break;
                }
            }
        }


        private class NOne
        {
            private readonly List<string> _listOfStrings = new List<string>() { "apple", "pear" };

            public void TaskLoop()
            {

                Console.WriteLine("Enter '-exit' for exit");

                while (true)
                {
                    Console.WriteLine("Enter new string");

                    string new1 = Console.ReadLine();

                    if (new1 == "-exit") break;

                    _listOfStrings.Add(new1);

                    foreach (var item in _listOfStrings)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Enter another string");

                    string new2 = Console.ReadLine();

                    if (new2 == "-exit") break;

                    int index = _listOfStrings.Count / 2;
                    _listOfStrings.Insert(index, new2);

                    foreach (var item in _listOfStrings)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private class NTwo
        {
            public Dictionary<string, int> students = new Dictionary<string, int>();

            public void TaskLoop()
            {
                Console.WriteLine("Введите '-exit' для выхода");

                while (true)
                {
                    Console.WriteLine("Enter student name");
                    string name = Console.ReadLine();
                    if (name?.ToLower() == "-exit") break;
                    int grade;

                    while (true)
                    {
                        Console.WriteLine("Enter grade ");
                        if (int.TryParse(Console.ReadLine(), out grade) && grade >= 2 && grade <= 5) break;
                        Console.WriteLine("Enter grade from 2 to 5");
                    }
                    students[name] = grade;
                    Console.WriteLine("Enter student for search");
                    string search = Console.ReadLine();
                    if (search == "-exit") break;

                    if (students.TryGetValue(search, out int foundGrade))
                        Console.WriteLine("Student and grade");
                    else Console.WriteLine("Student does not exist");
                }

            }
        }

        private class NThree
        {
            public void TaskLoop()
            {
                Console.WriteLine("введите '-exit' для выхода");
                while (true)
                {
                    LinkedList<string> list = new LinkedList<string>();
                    Console.WriteLine("Enter from 3 дto 6 elements.");

                    for (int i = 1; i <= 6; i++)
                    {
                        Console.WriteLine($"Element {i} (or '-exit'): ");
                        string val = Console.ReadLine();
                        if (val == "-exit") return;
                        list.AddLast(val);

                        if (i >= 3)
                        {
                            Console.WriteLine("Enough elements? (y/n): ");
                            if (Console.ReadLine().ToLower() == "y") break;
                        }
                    }

                    Console.WriteLine("Direct order: " + string.Join(" <-> ", list));

                    var reversed = new List<string>(list);
                    reversed.Reverse();
                    Console.WriteLine("Reverse order: " + string.Join(" <-> ", reversed));

                    Console.WriteLine("Reset? ( '-exit')");
                    if (Console.ReadLine() == "-exit") break;
                }
            }
        }
    }
}

       
        
        
   

