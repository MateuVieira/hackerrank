public static int pickingNumbers(List<int> a)
    {
        
        a.Sort();
        var smallest = 1000000;
        int count = 0;
        int largest_count = 0;

        foreach(var item in a)
        {
            if (smallest > item) 
            {
                smallest = item;
            }

            if (Math.Abs(item - smallest) > 1) 
            {
                 if (count > largest_count) 
                {
                     largest_count = count;
                }
                
            count = 1;
            smallest = item;
            } 
            else 
            {
                count ++;
            }
        }

        if (count > largest_count) 
        {
            largest_count = count;
        }

        return largest_count;
    }