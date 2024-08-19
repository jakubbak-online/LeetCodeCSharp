public class Solution {
    public bool IsPalindrome(int x) {
        char[] Front = x.ToString().ToCharArray();
        char[] Back;

        Back = (char[])Front.Clone();
        Array.Reverse(Back);

        Console.WriteLine(Front);
        Console.WriteLine(Back);

        bool isEqual = Enumerable.SequenceEqual(Front, Back);
        if (isEqual)
        {  
            return true;
        }else{
            return false;
        }
    }
}