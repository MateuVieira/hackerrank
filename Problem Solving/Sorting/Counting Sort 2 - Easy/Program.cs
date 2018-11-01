static int[] countingSort(int[] arr) {

        var aux = new int[100];
        for(int i = 0; i < arr.Length; i++)
        aux[arr[i]]++;

        var result = new List<int>();
        for(int j = 0; j< aux.Length; j++)
        {
            if(aux[j] !=0)
            {
                for(int i = 0; i < aux[j]; i++)
                result.Add(j);
            }
        }

        return result.ToArray();
    }