// See https://aka.ms/new-console-template for more information




using System.Reflection.Metadata;
using System.Text.RegularExpressions;

while (true)
{
    Console.WriteLine("Enter a roman number: ");
    string romanNumber = Console.ReadLine();
    int result = 0;

    Dictionary<string, int> numbers = new Dictionary<string, int>();

    numbers.Add("I", 1);
    numbers.Add("V", 5);
    numbers.Add("X", 10);
    numbers.Add("L", 50);
    numbers.Add("C", 100);
    numbers.Add("D", 500);
    numbers.Add("M", 1000);

    int previousNumber = 0;
    string romanNumberPattern = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$"; // regex to roman numbers

    for (int i = romanNumber.Length - 1; i >= 0; i--) // loop into entered romanNumber
    {
        int currentNumber = numbers[$"{romanNumber[i]}"]; // current roman number in the loop
        bool isARomanNumber = Regex.IsMatch(romanNumber, romanNumberPattern); // pattern that defines roman number

        if (isARomanNumber == true)
        { 
            if (currentNumber >= previousNumber)
            {
                result += currentNumber; // ex. VI = 5 + 1 = 6
            }
            else
            {
                result -= currentNumber; // 
            }

            previousNumber = currentNumber; // previous number un the loop
        }
        else
        { // if it is not a roman number
            Console.WriteLine("Invalid number.");
        }
    }
    Console.WriteLine("result = " + result);
}






