using System.Diagnostics.Metrics;

class Program
{
    public static void Main(string[] args)
    {
        string[] alphabet = new string[26];

        //Task 3 Beginning
        int lowerCaseAlphabetStart = 97;
        Console.WriteLine("---------------------------");
        Console.Write("Task 3 - ");

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToString((char)lowerCaseAlphabetStart);
            lowerCaseAlphabetStart += 1;
            Console.Write(alphabet[i]);
        }

        //Task 4 Beginning
        int lowerCaseAlphabetEnd = 122;
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.Write("Task 4 - ");

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToString((char)lowerCaseAlphabetEnd);
            lowerCaseAlphabetEnd -= 1;
            Console.Write(alphabet[i]);
        }

        //Task 5 Beginning
        int upperCaseAlphabetStart = 65;
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.Write("Task 5 - ");

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToString((char)upperCaseAlphabetStart);
            upperCaseAlphabetStart += 1;
            Console.Write(alphabet[i]);
        }

        //Task 6 Beginning
        int[] fibonacci = { 13, 1, 2, 3, 5, 8, 1, 34, 21, 55 };

        //Task 7 Beginning
        int largestNumber = 0;
        int arrayIncrement = 0;
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.Write("Task 7 - ");

        foreach (int i in fibonacci)
        {
            if (fibonacci[arrayIncrement] > largestNumber)
            {
                largestNumber = fibonacci[arrayIncrement];
            }
            arrayIncrement++;
        }
        Console.WriteLine($"The largest number in the fibonacci array is: {largestNumber}.");
    }
}
