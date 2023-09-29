class SimpleCalculator
{
    public static void Main()
    {
        char choice;

        do
        {
            Console.WriteLine("======== Simple Calculator ========");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            Console.Write("Choose Your Option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = option switch
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2,
                4 when num2 != 0 => num1 / num2,
                _ => throw new ArgumentException("Error: Invalid option"),
            };

            Console.WriteLine($"The result is {result}");
            Console.Write("Do you want to continue (y/n): ");
            choice = Console.ReadLine()[0];

        } while (choice == 'y' || choice == 'Y');
    }
}
