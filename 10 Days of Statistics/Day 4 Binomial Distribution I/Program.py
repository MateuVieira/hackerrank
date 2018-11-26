# Enter your code here. Read input from STDIN. Print output to STDOUT

def fact(n):
    return 1 if n == 0 else n*fact(n-1)

def comb(n, x):
    return fact(n) / (fact(x) * fact(n-x))

def b(x, n, p):
    return comb(n, x) * p**x * (1-p)**(n-x)

rate_b, rate_g = list(map(float, input().split(" ")))

odds = rate_b / rate_g
print(round(sum([b(i, 6, odds / (1 + odds)) for i in range(3, 7)]), 3))