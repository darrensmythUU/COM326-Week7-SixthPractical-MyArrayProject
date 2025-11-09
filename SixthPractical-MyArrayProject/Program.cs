using System.Diagnostics.Metrics;

class Program
{
    public static void Main(string[] args)
    {
        int lowerCaseAlphabetStart = 97;
        int lowerCaseAlphabetEnd = 122;
        string[] alphabet = new string[26];

        //Task 3 Beginning
        Console.WriteLine("---------------------------");
        Console.Write("Task 3 - ");

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToString((char)lowerCaseAlphabetStart);
            lowerCaseAlphabetStart += 1;
            Console.Write(alphabet[i]);
        }

        //Task 4 Beginning
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.Write("Task 4 - ");

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = Convert.ToString((char)lowerCaseAlphabetEnd);
            lowerCaseAlphabetEnd -= 1;
            Console.Write(alphabet[i]);
        }
    }
}
