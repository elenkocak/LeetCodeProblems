public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the worlds with ','");
        string input = Console.ReadLine();
        string[] words = input.Split(",");
        LongestCommonPrefix(words);
    }
    
    public static string LongestCommonPrefix(string[] words)
    {
      
        Array.Sort(words);
        string prefix = "";
        for (int i = 0; i < words[0].Length; i++) 
        {
            char c = words[0][i];
            for (int j = 1; j < words.Length; j++)
            {
                var test = words[j][i];
                if (i >= words[j].Length || words[j][i] != c)
                {
                    return prefix;
                }
            }
            prefix += c;

        }
        return prefix;
    }
}