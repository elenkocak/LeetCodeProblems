internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dizi elemanlarını girin (virgülle ayrırarak):");
        string input = Console.ReadLine();

        string[] numbersAsString = input.Split(',');
        int[] numbers = Array.ConvertAll(numbersAsString, int.Parse);
        IsPalindromicList(numbers);
        Console.ReadLine();

    }
    public static bool IsPalindromicList(int[] numbers)
    {
       
        int reversed = 0; int original = 0;
        for (int j = 0; j < numbers.Length; j++)
        {
            original = (original * 10) + numbers[j];
        }
        if (original == 0 || original % 10 == 0)
            return true;
        int result = original;
        while (result > 0)
        {
            reversed = (reversed * 10) + (result % 10);
            result /= 10;
        }
    
        Console.WriteLine($"Orijinal: {original}, Reverse: {reversed}");
        return reversed==original;
    }
}