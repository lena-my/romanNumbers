// See https://aka.ms/new-console-template for more information




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

    for (int i = romanNumber.Length - 1; i >= 0; i--) // loop into entered romanNumber
    {
        int currentNumber = numbers[$"{romanNumber[i]}"]; // current roman number in the loop

        if (currentNumber >= previousNumber) {
            result += currentNumber; // ex. VI = 5 + 1 = 6
        }
        else {
            result -=  currentNumber; // 
        }

        previousNumber = currentNumber; // previous number un the loop
    }


    Console.WriteLine("result = " + result);

}






