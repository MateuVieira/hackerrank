{  return arr
.GroupBy(a => a)
.Select(b => new{ Bird = b.Key, Count = b.Count() })
.OrderByDescending(c => c.Count)
.ThenBy(d => d.Bird)
.FirstOrDefault().Bird;
}
