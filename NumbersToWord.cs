/* Enter a Number and convert it into words like 45200 => fourty five thousand two hundred */
class NumberToWordsConverter
{
    private static string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    private static string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    private static string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    public static string ConvertToWords(int number)
    {
        if (number == 0)
            return units[0];

        if (number < 0)
            return "Negative " + ConvertToWords(-number);

        if (number < 10)
            return units[number];

        if (number < 20)
            return teens[number - 10];

        string words = "";

        if (number >= 1000)
        {
            words += ConvertToWords(number / 1000) + " Thousand ";
            number %= 1000;
        }

        if (number >= 100)
        {
            words += ConvertToWords(number / 100) + " Hundred ";
            number %= 100;
        }

        if (number >= 10)
        {
            words += tens[number / 10];
            if (number % 10 > 0)
                words += "-" + units[number % 10];
        }

        return words.Trim();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string words = ConvertToWords(number);

        Console.WriteLine("In words: " + words);
    }
}
