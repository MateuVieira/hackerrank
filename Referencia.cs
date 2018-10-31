{  return arr\par
.GroupBy(a => a)\par
.Select(b => new\{ Bird = b.Key, Count = b.Count() \})\par
.OrderByDescending(c => c.Count)\par
.ThenBy(d => d.Bird)\par
.FirstOrDefault().Bird;\fs22\par
}
