public class Solution {
    public void Rotate(int[] nums, int k)
{
    int sizeArray = nums.Length;
    // Console.WriteLine($"sizeArray = {sizeArray}");

    int[] nums2 = new int[sizeArray];

    for (int i = 0; i < sizeArray; i++)
    {
        int newPosition = (i + k) % sizeArray;
        // Console.WriteLine($"i={i}, newPosition = {newPosition}");
        nums2[newPosition] = nums[i];

    }

    Array.Copy(nums2, nums, sizeArray);

    /*
    foreach (int i in nums)
    {
        Console.WriteLine(i);
        int newPosition = (sizeArray + k) % sizeArray - 2;
        Console.WriteLine($"newPosition = {newPosition}");
        nums2[newPosition] = nums[i];
    }*/
}
}