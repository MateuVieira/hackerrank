static long repeatedString(string s, long n) {

        var length_s = s.Length;
        var aux = n%length_s;
        var count = 0;
        long result = 0;

        foreach(var item in s)
        {
            if(item == 'a')
            {
                count++;
            }
        }

        result = count*(n/length_s);

        for(int i = 0; i < aux; i++)
        {
            if(s[i] == 'a')
            {
                result++;
            }
        }

        return result;
    }