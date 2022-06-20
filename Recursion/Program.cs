public class program
{
    static int findSum(int[] a, int N)
    {
        if (N <= 0)
            return 0;
        return (findSum(a, N - 1) + a[N - 1]);
    }

    public static void Main(string[] args)
    {
        int[] A = { 1, 2, 3, 4, 5 };
        
        Console.WriteLine(findSum(A, A.Length));
    }
}