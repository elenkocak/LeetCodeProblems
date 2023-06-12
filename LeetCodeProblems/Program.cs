public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Roman Numbers:");
        var sendRomanNumber = Console.ReadLine();
        var result= RomanNumberToInt(sendRomanNumber);
        Console.WriteLine(result);
        Console.ReadKey();  
    }
    #region Algoritma
    /*Önce parametrede verilen sayının uzunluğu kadar döngüde dönmemiz lazım ki böylece parametre elemanlarına ulaşabilelim ve büyük küçük kontrolü yapalım
     * Sonra döngünün i'ninci elemanı şu anki elemanımız olur.
     * Daha sonra dictionarynin elemanında currentNumber varsa bunu bir int değişkenine parse ederiz
     *Şimdi ise i'ninci ve i+1 inci yani I ve X elemanını kontrol edicez. (parametrede IX olduğunu düşündüm)
     *Hata vermemesi için sonuncu elemanın parametre uzunluğundan küçük olması lazım çünkü biz zaten soldaki sayıyı kontrol etmek istiyoruz.
     *Sonra dictionary değişkeninin şu anki değeri bir sonraki parametre elemanından büyük mü küçük mü bakarız
     */
    #endregion
    public static int RomanNumberToInt(string enteredRomanNumber)
    {
        Dictionary<char, int> romanDictionary=new Dictionary<char, int>();
        romanDictionary.Add('I', 1);
        romanDictionary.Add('V', 5);
        romanDictionary.Add('X', 10);
        romanDictionary.Add('L', 50);
        romanDictionary.Add('C', 100);
        romanDictionary.Add('D', 500);
        romanDictionary.Add('M', 1000);

        int numberOfSum = 0;
        for (int i = 0; i < enteredRomanNumber.Length; i++)
        {
            var currentNumber= enteredRomanNumber[i];  
            romanDictionary.TryGetValue(currentNumber, out int number);
         
            if (i+1 < enteredRomanNumber.Length && romanDictionary[currentNumber] < romanDictionary[enteredRomanNumber[i+1]]) // IX durumunda I küçük olduğu için eksi çıkacak değer kontrolü
            {
               numberOfSum -= number;   
            }
            else
            {
                numberOfSum += number; // Bu da IX da X'in kontrolü
            }
        }
        return numberOfSum;
       
    }

}