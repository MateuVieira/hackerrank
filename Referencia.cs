{\rtf1\ansi\deff0\nouicompat{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
{\*\generator Riched20 10.0.17763}\viewkind4\uc1 
\pard\sa200\sl276\slmult1\f0\fs36\lang22  return arr\par
.GroupBy(a => a)\par
.Select(b => new\{ Bird = b.Key, Count = b.Count() \})\par
.OrderByDescending(c => c.Count)\par
.ThenBy(d => d.Bird)\par
.FirstOrDefault().Bird;\fs22\par
}
