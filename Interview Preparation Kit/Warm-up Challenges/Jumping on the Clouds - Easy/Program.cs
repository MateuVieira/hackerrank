static int jumpingOnClouds(int[] c) {

       var n = c.Length;
       var count = 0;

       for(int i=0;i<n;)
            {
                if(i+2<n)
                {
                    if (c[i + 2] == 0)
                    {
                        count++;
                        i += 2;
                    }
                    else if(c[i + 1] == 0)
                    {
                        count++;
                        i += 1;
                    }
                }
                else
                {
                    if(i<n-1)
                    count++;
                    i++;
                }
            }
            return count;
    }