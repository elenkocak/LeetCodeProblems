internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int AddTwoNumbers(int[] list1, int[] list2)
    {
        Console.WriteLine("Enter de first list's items");
        int[] array1 = list1;
        Console.WriteLine("Enter the second list's items");
        int[] array2 = list2;
        if (array1.Length != array2.Length && array1.Length>=3 || array2.Length > 3)
        {
            Console.WriteLine("List items must be 3 elements");
        }
        int total = 0;
        array1.Reverse();
        array2.Reverse();
        for (int i = 0; i < list1.Length; i++)
        {
            for (int j = 0; j < list2.Length; j++)
            {
                total = array1[i] + array2[j];
            }
        }
        return total;
    }
}