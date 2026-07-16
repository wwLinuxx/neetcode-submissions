public class Solution
{
    public bool IsPalindrome(string s)
        => ToLwr(s).Equals(Replace(ToLwr(s)));

    string ToLwr(string str)
    {
        StringBuilder result = new();

        foreach (char c in str)
        {
            if (c >= 'A' && c <= 'Z')
                result.Append((char)(c + 32));
            else if (c >= 'a' && c <= 'z')
                result.Append(c);
            else if (c >= '0' && c <= '9')
                result.Append(c);
        }

        return result.ToString();
    }

    string Replace(string str)
    {
        StringBuilder result = new();

        for (int i = str.Length - 1; i >= 0; i--)
            result.Append(str[i]);

        return result.ToString();
    }
}