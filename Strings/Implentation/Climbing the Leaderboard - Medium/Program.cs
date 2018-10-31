static int[] climbingLeaderboard(int[] scores, int[] alice) {

        
        var alice_rank = new int[alice.Length];
        var grouped = scores
            .GroupBy(a => a)
            .Select((g, i) => new{ Id = g.Key, Pos = i + 1})
            .OrderBy(o => o.Id)
            .ToList();

        var count = grouped.Count;
        var index = count-1;

        for (int i = alice.Length-1; i >= 0 ; i--)
        {
            for (int j = index; j >= 0; j--)
            {
                if (grouped[j].Id < alice[i])
                {
                   alice_rank[i] = grouped[j].Pos == 1 ? 1 : grouped[j].Pos;
                   break;
                }
                if (grouped[j].Id == alice[i])
                {
                   alice_rank[i] = grouped[j].Pos;
                   break;
                }
                
                alice_rank[i] = grouped[j].Pos+1;
            }
            //index--;
        }
    
        return alice_rank;

    }