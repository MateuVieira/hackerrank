# Enter your code here. Read input from STDIN. Print output to STDOUT

from statistics import median

size = int(input())
numbers = list(map(int, input().split()))

numbers.sort()

t=len(numbers)//2
if len(numbers)%2==0:
    L=numbers[:t]
    U=numbers[t:]
else:
    L=numbers[:t]
    U=numbers[t+1:]
    
print(int(median(L)))
print(int(median(numbers)))
print(int(median(U)))