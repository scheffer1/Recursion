public class program
{
    static int findSum(int[] array, int N)
    {
        if (N <= 0)
            return 0;
        return (findSum(array, N - 1) + array[N - 1]);
    }

    static int largestElement(int[] start, int index) {
        if (index>0)
        {
            return Math.Max(start[index], largestElement(start, index - 1));
        } else {
            return start[0];
        }
    }
    public static void Main(string[] args)
    {
        int[] A = { 1, 2, 3, 4, 5 };
        
        Console.WriteLine(findSum(A, A.Length));
        Console.WriteLine(largestElement(A, A.Length-1));
    }
}