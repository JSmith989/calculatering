using System;

namespace Calculatering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type multiply, add, square, divide, or average");
            var choice = Console.ReadLine();
            Console.WriteLine("type 3 numbers separated by a comma");
            var input = Console.ReadLine();
            var numberSplit = input.Split(",");
            var a = 0;
            var b = 0;
            var c = 0;
            var counter = 0;

            foreach (var number in numberSplit)
            {
                int parsedNumber = Int32.Parse(number);
                if (counter == 0)
                {
                    a += parsedNumber;
                    counter++;
                }
                else if (counter == 1)
                {
                    b += parsedNumber;
                    counter++;
                }
                else if (counter == 2)
                {
                    c += parsedNumber;
                    counter++;
                }
            }
            if (choice == "multiply")
            {
                var multiply = a * b * c;
                Console.WriteLine(multiply);
            }
            else if (choice == "add")
            {
                var add = a + b + c;
                Console.WriteLine(add);
            }
            else if (choice == "square")
            {
                var square1 = a * a;
                var square2 = b * b;
                var square3 = c * c;
                Console.WriteLine(square1);
                Console.WriteLine(square2);
                Console.WriteLine(square3);
            }
            else if (choice == "divide")
            {
                var divide = a / b / c;
                Console.WriteLine(divide);

            }
            else if (choice == "average")
            {
                var average = a + b + c / 3;
                Console.WriteLine(average);
                
            }

        }
    }
}
