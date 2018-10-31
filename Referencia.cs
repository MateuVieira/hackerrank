{  return arr
.GroupBy(a => a)
.Select(b => new{ Bird = b.Key, Count = b.Count() })
.OrderByDescending(c => c.Count)
.ThenBy(d => d.Bird)
.FirstOrDefault().Bird;
}


var grouped = scores
                      .GroupBy(a => a)
                      .Select((g, i) => new{ Id = g.Key, Pos = i + 1})
                      .OrderBy(o => o.Id)
                      .ToList();
