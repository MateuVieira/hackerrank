# Enter your code here. Read input from STDIN. Print output to STDOUT

# Enter your code here. Read input from STDIN. Print output to STDOUT

p1, p2 = [int(i) for i in input().split()]
n = int(input())
p = p1/p2
q = 1-p

# Calculate Geometric Distribution
print (round(sum([(q**(n-x))*p for x in range(1, 6)]),3))