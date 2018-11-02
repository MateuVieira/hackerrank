static string isValid(string s) {

        var temp = s.ToArray().GroupBy(a => a)
                    .Select(b => b.Count()).OrderByDescending(c => c);

        int x = 0, y = 0;
        foreach(var item in temp)
        {
            if (item > x)
                x = item;
            if (item != x && x > 0)
                y += item;
        }
        return ((y - 1) - x == 0 || y == 0 || y - 1 == 0) ? "YES" : "NO";
    }