public class Program
{
    private static void Main(string[] args)
    {
        var result=MergeTwoSortedListts();
        foreach(var item in result)
        {
            Console.Write(item + " - ");
        }
        Console.ReadKey();
    }
    public static List<int> MergeTwoSortedListts()
    {
        var listOne=new List<int>();
        listOne.Add(1);
        listOne.Add(2); 
        listOne.Add(4);
        var listTwo=new List<int>();
        listTwo.Add(1);
        listTwo.Add(3);
        listTwo.Add(4);

        var listLast=new List<int>();
        listLast.AddRange(listOne);
        listLast.AddRange(listTwo); 
        listLast.Sort();    
        return listLast;
    }
}