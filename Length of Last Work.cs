public class Solution {
    public int LengthOfLastWord(string s)
{
    char[] chars = s.ToCharArray();
    int length = 0;

    bool breakValue = false;
    for (int i = chars.Length - 1; i >= 0; i--)
    {
        int unicode = (int)chars[i];
        if (unicode == 32 && breakValue == false)
        {
            // Console.WriteLine("spacja");
            continue;
        }

        breakValue = true;

        if (unicode == 32)
        {
            break;
        }


        length++;
        // Console.WriteLine(unicode);
    }

    return length;
}
}