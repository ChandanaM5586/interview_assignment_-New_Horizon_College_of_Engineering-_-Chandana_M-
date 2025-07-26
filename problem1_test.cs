class Prob1Test
{
    static void Main()
    {
        int[][] testCases = {
            new int[] {1, 2, 3, -1},
            new int[] {1, 2, -3, 4},
            new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2},
            new int[] {0, 0, 0, 1}
        };

        foreach (var test in testCases)
        {
            bool result = Prob1.DuplicateValue(test);
            Console.WriteLine($"Input: [{string.Join(", ", test)}] → Contains Duplicate: {result}");
        }
    }
}    
