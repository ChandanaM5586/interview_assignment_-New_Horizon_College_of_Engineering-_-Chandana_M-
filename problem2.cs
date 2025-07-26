public class Prob2
{
    public static void MovingZeros(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] == 0 && nums[j + 1] != 0)
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
    }
}
