static int commonChild(string s1, string s2) {

        int[,] op = new int[s1.Length + 1, s2.Length + 1];
        for (int i = 1; i < s1.Length + 1; i++)
        {   
            for (int j = 1; j < s2.Length + 1; j++)
            {
                if (s1[i - 1] == s2[j - 1])
                {
                    op[i, j] = op[i - 1, j - 1] + 1;
                }
                else
                {
                    op[i, j] = Math.Max(op[i - 1, j], op[i, j - 1]);
                }
            }
        }
        int maxLen = op[s1.Length, s2.Length];
        char[] result = new char[maxLen];
        int s1p = s1.Length;
        int s2p = s2.Length;
        while (s1p > 0 && s2p > 0)
        {
            if (s1[s1p - 1] == s2[s2p - 1])
            {
                result[maxLen - 1] = s1[s1p - 1];
                maxLen--;
                s1p--;
                s2p--;
            }
            else if (op[s1p - 1, s2p] <= op[s1p, s2p - 1])
            {
                s2p--;
            }
            else
            {
                s1p--;
            }
        }
        return result.Length;
    }