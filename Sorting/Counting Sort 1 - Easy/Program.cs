static int[] countingSort(int[] arr) {

        var result = new int[100];

        for( int i = 0; i < arr.Length; i++)
            result[arr[i]]++;



        return result;
    }