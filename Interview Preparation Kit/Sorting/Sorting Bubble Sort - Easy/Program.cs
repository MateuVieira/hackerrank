var count = 0;
        var n = a.Length;
        for (int i = 0; i < n; i++) 
        {
    
            for (int j = 0; j < n - 1; j++) 
            {
            // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                { 
                    var temp = a[j];
                    var temp2 = a[j + 1]; 
                    a[j + 1] = temp;
                    a[j] = temp2;
                    count++;
                }
            }
        }
        Console.WriteLine($"Array is sorted in {count} swaps."
                            + $"\nFirst Element: {a[0]}" 
                            + $"\nLast Element: {a[a.Length-1]}");
    
    }