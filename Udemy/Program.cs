namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Input the first Number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");
            string operand = Console.ReadLine().ToUpper();
            operate(number2, number1, operand);


            void operate(int num1, int num2, string operand)
            {
                switch (operand)
                {
                    case "A":
                        int sum = num1 + num2;
                        printEquation(num1, num2, sum, "+");
                        break;
                    case "B":
                        int difference = num1 - num2;
                        printEquation(num1, num2, difference, "-");
                        break;
                    case "M":
                        int product = num1 * num2;
                        printEquation(num1, num2, product, "*");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                
            }


            void printEquation(int num1, int num2, int result, string @operator) 
            {
                Console.WriteLine($"{num1} {@operator} {num2} = {result}");
            }
        }
    }
}