class Program
{
    public static void Main(string[] args)
    {
        int lowerCaseAlphabetChar = 97;
        string[] alphabet = new string[26];

        for (int i = 0; i < alphabet.Length - 1; i++)
        {
            alphabet[i] = Convert.ToString((char)lowerCaseAlphabetChar);
            lowerCaseAlphabetChar += 1;
        }

        foreach (string letter in alphabet)
        {
            Console.Write(letter);
        }
    }
}
