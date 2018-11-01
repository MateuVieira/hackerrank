static void minimumBribes(int[] q) {

        var temp = 0;
        var temp2 = 0;
        var count = 0;
        foreach (int i in q)
        {
            bool matched = true;
            for (int x = 0; x < q.Length - 1; x++)
            {
                if (q[x] - (x + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                if (q[x] > q[x + 1])
                {
                    temp = q[x + 1];
                    temp2 = q[x];
                    q.SetValue(temp2, x + 1);
                    q.SetValue(temp, x);
                    count++;
                    continue;
                }
                if(q[x] != x + 1) {matched = false;}
            }
            if(matched){break;}             
        }
        Console.WriteLine(count);
    }