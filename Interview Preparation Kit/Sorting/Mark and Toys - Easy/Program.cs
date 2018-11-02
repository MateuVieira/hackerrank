static int maximumToys(int[] prices, int k) {
        var sum = 0;
        var count = 0;
        var temp  = prices.OrderBy(a => a);
        foreach(var item in temp)
        {
            sum +=item;
            if(sum > k)
                return count;
            count++;    
        }
        return count;
    }