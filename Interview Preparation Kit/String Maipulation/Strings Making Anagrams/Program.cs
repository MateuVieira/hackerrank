static int makeAnagram(string a, string b) {

        var count = 0;
        var aux = 0;

        var temp = a.GroupBy(x => x)
                    .Select(y => new{ Id = y.Key, Cont = y.Count()})
                    .OrderBy(z => z.Cont);
        var temp2 = b.GroupBy(x => x)
                    .Select(y => new{ Id = y.Key, Cont = y.Count()})
                    .OrderBy(z => z.Cont);

        foreach(var a_item in temp)
        {
            foreach(var b_item in temp2)
            {
                if(a_item.Id == b_item.Id)
                {   
                    count += Math.Abs(a_item.Cont - b_item.Cont);
                    aux += a_item.Cont + b_item.Cont;   
                }
            }
        }
        return a.Length + b.Length + count - aux ;
    }