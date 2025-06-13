internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Sum([6, 2, 1, 8, 10]));
    }
    public static int SumLinq(int[] numbers)
    {
        if (numbers is null) return 0;
        return numbers
            .OrderBy(x => x).
            Skip(1)
            .Take(numbers.Length - 2)
            .Sum();
    }

    // using bubble sort on this one
    public static int Sum(int[] numbers)
    {
        var sum = 0;
        if (numbers is null) return 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] < numbers[j])
                {
                    var temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        for(int i = 0; i < numbers.Length;i++)
        {
            if(i > 0 && i < numbers.Length - 1)
            {
                sum+= numbers[i];
            }
        }
        return sum;
    }
}