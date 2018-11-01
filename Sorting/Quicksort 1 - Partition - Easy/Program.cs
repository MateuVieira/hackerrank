static int[] quickSort(int[] arr) {
            
        var value = arr[0];
        var left = new List<int>();
        var right = new List<int>();

        foreach(var item in arr)
        {
            if(value > item)  
            {
                left.Add(item);
            }
            if(value < item)
            {
                right.Add(item);
            }

        }
        var result = new List<int>();
        result.AddRange(left);
        result.Add(value);
        result.AddRange(right);

        return result.ToArray();
    }