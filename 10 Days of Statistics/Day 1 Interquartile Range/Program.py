# Enter your code here. Read input from STDIN. Print output to STDOUT

from statistics import median

size = int(input())
numbers = list(map(int, input().split()))
frequency = list(map(int, input().split()))

s=[]
for i in range(size): s += ([numbers[i]] * frequency[i])
s.sort()

t=len(s)//2
if len(s)%2==0:
    L=s[:t]
    U=s[t:]
else:
    L=s[:t]
    U=s[t+1:]
  
print(round(float(median(U) - median(L)),1))
