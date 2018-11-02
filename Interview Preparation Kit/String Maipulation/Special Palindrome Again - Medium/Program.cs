static long substrCount(int n, string s) {

        return countPalindrome(s, 0, s.Length - 1) + s.Length;
       
    }

    static long countPalindrome(string s, int start, int end)
{
    if (start > end)
        return 0;

    long count = 0;
    int mid = (end + start) / 2;

    count += countPalindrome(s, mid);
    count += countPalindrome(s, start, mid - 1);
    count += countPalindrome(s, mid + 1, end);

    return count;
}

static long countPalindrome(string s, int mid)
{
    if (mid > s.Length - 1 || mid < 0)
        return 0;

    long count = 0;

    char midChar = s[mid];

    // first - check for case1 type palindrome.
    int i = mid + 1;
    while (i < s.Length && s[i++] == midChar)
        count++;

    // second - check for case2 type palindrome.
    if (mid > 0 && mid < s.Length - 1)
    {
        int leftIndex = mid - 1, rightIndex = mid + 1;

        char leftChar = s[leftIndex--], rightChar = s[rightIndex++];

        if (leftChar == rightChar && leftChar != midChar)
        {
            count++;
            while (leftIndex >= 0 && 
                rightIndex < s.Length &&
                s[leftIndex] == s[rightIndex] && 
                leftChar == s[leftIndex-- + 1] && 
                s[rightIndex] == s[rightIndex++ - 1])
            {
                count++;
            }
        }
    }
    return count;
}