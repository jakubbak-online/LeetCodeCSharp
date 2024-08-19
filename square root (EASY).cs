public class Solution {
    public int MySqrt(int x)
{
    long divider = 1;

    while (divider*divider<=x)
    {
        divider += 1;
        // Console.WriteLine(divider);
    }
    return (int)divider-1;
}
}