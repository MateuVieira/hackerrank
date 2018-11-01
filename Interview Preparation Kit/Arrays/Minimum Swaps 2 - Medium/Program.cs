static int minimumSwaps(int[] arr) {

        var count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        while(arr[i] != i + 1)
        {
            var swapKey = arr[i] - 1;

            var temp = arr[i];

            arr[i] = arr[swapKey];
            arr[swapKey] = temp;

            count++;
        }
    }