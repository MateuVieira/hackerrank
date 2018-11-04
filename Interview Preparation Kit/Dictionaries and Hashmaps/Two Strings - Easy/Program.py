def twoStrings(s1, s2):
    temp = Counter(s1)
    temp2 = Counter(s2)
    dif = (temp - temp2)
    return ( "NO" if (dif == temp) else "YES")