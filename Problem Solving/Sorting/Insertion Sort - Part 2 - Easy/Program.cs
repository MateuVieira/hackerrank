static void insertionSort2(int n, int[] arr) {

        for (int i = 1; i < n; i++) 
        {
            for (int j = 0; j < i; j++) 
            {   
               if (arr[j] > arr[i]) 
                {
                    var temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }