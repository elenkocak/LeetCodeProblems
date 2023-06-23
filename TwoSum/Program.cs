public class Program
{
    private static void Main(string[] args)
    {
        int target = 9;
        int[] nums = { 3,1,2, 7, 11, 15 }; 
       var write= TwoSum2(nums, target);
        foreach(int x in write)
        {
            Console.WriteLine(x);

        }
        Console.ReadLine(); 
    }

    public static int[] TwoSum2(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) 
        {
           
            int complementNumber = target - nums[i];    
            if (map.ContainsKey(complementNumber))
            {
                return new int[] { map[complementNumber], i };
            }
            map[nums[i]] = i;
           
        }
        return new int[0];
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++) 
        {
            Dictionary<int, int> dict=new Dictionary<int,int>();
            for (int j = 0; j < nums.Length; j++)
            {
                int total = nums[i] +nums[j];
                if (total == target)
                {
                    if (!dict.ContainsKey(nums[i]))
                    {
                        dict.Add(i, nums[i]);
                        if (!dict.ContainsKey(nums[j]))
                        {
                            dict.Add(j, nums[j]);

                            int[] test=new int[] {i,j};
                            for (int k = 0; k < test.Length; k++)
                            {
                                Console.WriteLine(test[k]);
                            }
                            return test;
                        }
                    }

                }
                
            }
        }
        return Array.Empty<int>();
    }
    //public static int[] TwoSum3(in)
}
