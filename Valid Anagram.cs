public class Solution {
    public bool IsAnagram(string s, string t)
{
    List<char> sList = new List<char>(s.ToCharArray());
    List<char> tList = new List<char>(t.ToCharArray());

    while (sList.Count > 0)
    {
        bool isPresent = false;
        for (int i = 0; i < tList.Count; i++)
        {
            if (tList[i] == sList[0])
            {
                tList.RemoveAt(i);
                sList.RemoveAt(0);
                isPresent = true;
            }
        }
        if (!isPresent)
        {
            return false;
        }

        if (sList.Count == 0 || tList.Count == 0) {  break; }
    }

    /*
    for (int i = 0; i < sList.Count; i++)
    {
        Console.WriteLine(sList[i]);
    }
    Console.WriteLine($"sList Count {sList.Count}");
    Console.WriteLine("-----------------");
    Console.WriteLine($"tList Count {tList.Count}");
    for (int i = 0; i < tList.Count; i++)
    {
        Console.WriteLine(tList[i]);
    }
    */

    bool toReturn = false;
    if (tList.Count == 0 && sList.Count == 0) { toReturn = true; }

    return toReturn;
}
}