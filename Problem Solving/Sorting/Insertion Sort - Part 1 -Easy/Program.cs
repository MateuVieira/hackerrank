static void insertionSort1(int n, int[] arr) {

      int num = arr[arr.Length-1];
        for(int i = arr.Length-2; i >=0; i--)
        {
            if(num < arr[i])
            {
                arr[i+1]=arr[i];              
                Console.WriteLine(String.Join(" ", arr));
                if(i==0)
                { 
                    arr[i] = num;
                    Console.WriteLine(String.Join(" ", arr));                                     
                }
            }           
            else
            {
                if (arr[i + 1] != num)
                { 
                    arr[i + 1] = num;
                    num = arr[i];
                    Console.WriteLine(String.Join(" ", arr)); 
                }
                else num = arr[i];
            }
        }        

    }