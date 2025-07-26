class ProbTest
{
    static void Main()
    {
        int[][] testCases = {
            new int[] {0, 1, 0, 3, 12},
            new int[] {1, 2, 3, 4},
            new int[] {0, 0, 0, 0},
            new int[] {0, 1, 0, 4, 21}
        };

        foreach (var test in testCases)
        {
            Console.WriteLine($"Original: [{string.Join(", ", test)}]");
            Prob2.MovingZeros(test);
            Console.WriteLine($"Modified: [{string.Join(", ", test)}]\n");
        }
    }
}
