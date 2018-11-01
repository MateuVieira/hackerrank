static int[] icecreamParlor(int m, int[] arr) {

        var result = new int[2];

        for (int i = 0; i < arr.Length; i ++)
        {
            if (arr[i] < m )
            {
                result[0] = i + 1;                  
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j != i && arr[i] + arr[j] == m)
                    {
                        result[1] = j + 1;
                        Array.Sort(result);
                        return result;                        
                    }                    
                }                
            }                    
        }
        return result;
    }