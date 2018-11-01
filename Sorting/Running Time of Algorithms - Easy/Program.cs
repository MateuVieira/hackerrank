static int runningTime(int[] arr) {

          var j = 0; 
          var cont = 0;

        for (var i = 1; i < arr.Length; i++) { 
            var value = arr[i]; 
            j = i - 1; 
            while (j >= 0 && value < arr[j]) { 
                arr[j + 1] = arr[j];
                j = j - 1; 
                cont++;
            } 
            arr[j + 1] = value; 
        } 
        Console.WriteLine(cont); 
        return cont;
    }