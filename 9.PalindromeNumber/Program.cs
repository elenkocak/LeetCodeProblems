public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int number=Convert.ToInt32(Console.ReadLine());
        var isPalindrome = PalindromeNumber1(number);
        Console.WriteLine(isPalindrome);

    }

    public static bool PalindromeNumber2(string number)
    {

        for (int i = 0; i < number.Length; i++)
        {
            if (number.Length == 2 && number[i] == number[i + 1])
            {
                return true;
            }
            else if (number.Length == 3 && number[i] == number[i + 2])
            {
                return true;
            }
            else if (number.Length == 4 && number[i] == number[i + 3])
            {
                return true;
            }
        }
        return false;
    }

    public static bool PalindromeNumber1(int x)
    {

        if (x < 0 || (x % 10 == 0 ))
            return false;

        int reversed = 0;
        int original = x;

        while (x > 0)
        {
            var y = x;
          var test=  reversed =(reversed*10) + (x % 10); //reverse*10 =>basamağı sola doğru kaydırmak için x%10 x'in son basamağını bulmak için
            
            x /= 10; //Burada da yukarıda incelediğimiz son basamağı burada çıkarıyoruz ki sayıyı inceleyebilelim
        }

        return reversed == original;
    }
}