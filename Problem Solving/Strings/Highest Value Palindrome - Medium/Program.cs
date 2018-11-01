static string highestValuePalindrome(string s, int n, int k)
    {
      
        char[] result = new char[n];
        int meio = n/2;
        int cont = 0;

        for(int i = 0; i < meio; i++)
        {
            if(s[i] != s[n-1-i])
            {
                cont++;
            }
        }
        if( cont > k)
        {
            return "-1";
        }

        for(int i = 0; i < meio; i++)
        {
            if(s[i] != s[n-1-i])
            {
                if(cont == k)
                {
                    result[i] = (s[i] > s[n-1-i]) ?  s[i] : s[n-1-i];
                    result[n-1-i] = result[i];
                    cont--;
                    k--;
                }
                 else
                {
                   if (s[i] == '9' || s[n - 1 - i] == '9')
                    {
                        result[i] = '9';
                        result[n - 1 - i] = result[i];
                        cont--;
                        k--;
                    }
                    else
                    {
                        result[i] = '9';
                        result[n - 1 - i] = result[i];
                        cont--;
                        k -= 2;
                    }
                }
            }
            else if(k >= 2 && (cont <= k - 2) && s[i] != '9') 
            {
                result[i] = '9';
                result[n-1-i] = '9';
                
                k -= 2;
            }
            else 
            {
                result[i] = s[i];
                result[n-1-i] = s[n-1-i];
            }
            
        }
        if(n%2  == 1) 
        {
             if(k > 0) result[n/2] = '9';
            else result[n/2] = s[n/2];
            
        }
    
        return string.Join("",result);
    }