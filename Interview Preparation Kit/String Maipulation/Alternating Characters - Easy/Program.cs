static int alternatingCharacters(string s) {
        var count = 0;

            for(int i = 0; i < s.Length-1; i++ )
            {  
                count +=  s[i] == s[i+1] ? 1 : 0;
            }
        return count;
    }