      for (int i = 0; i < arr.Count/2; i++) arr[i][1] = "-"; 

        var result = new List<string>();
        for(int i = 0; i < 100; i++)
        {
            for(int j = 0; j < arr.Count; j++)
            {           
              if(i.ToString() == arr[j][0])
              {
                result.Add(arr[j][1]);              
              }              
            }
        }

        Console.Write(String.Join(" ", result));


**************************************************************************************

for (int i = 0; i < arr.Count / 2; i++) arr[i][1] = "-";

    Console.WriteLine(string.Join(" ", arr
        .OrderBy(ob => int.Parse(ob[0]))
        .GroupBy(gb => int.Parse(gb[0]), ret => ret[1])
        .SelectMany(sm => sm)));