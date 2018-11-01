static int[] rotLeft(int[] a, int d) {

        var result = new List<int>();

        for(int i = d;  i < a.Length; i++ )
            result.Add(a[i]);

        for(int i = 0; i < d; i++)
            result.Add(a[i]);

        return result.ToArray();
    }