static int commonChild(string s1, string s2) {

    var c = new int[s1.Length + 1, s2.Length + 1];

    for (int i = 1; i <= s1.Length; i++)
    {
        for (int j = 1; j <= s2.Length; j++)
        {
            c[i, j] = s1[i - 1] == s2[j - 1] ?
                c[i - 1, j - 1] + 1 :
                Math.Max(c[i, j - 1], c[i - 1, j]);
        }
    }

    return c[s1.Length, s2.Length];
}