public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;
            
        Dictionary<char, int> dict = [];

        foreach (char l in s)
        {
            if (dict.TryGetValue(l, out int value))
                dict[l] = value + 1;
            else
                dict.Add(l, 1);
        }

        foreach (char l in t)
        {
            if (dict.TryGetValue(l, out int value))
                dict[l] = value - 1;
            else
                dict.Add(l, 1);
        }

        foreach (var l in dict)
            if (dict.TryGetValue(l.Key, out int value) && value > 0)
                return false;

        return true;
    }
}