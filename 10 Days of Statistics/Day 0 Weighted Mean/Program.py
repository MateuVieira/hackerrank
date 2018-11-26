size = int(input())
numbers = list(map(int, input().split()))
weights = list(map(int, input().split()))

numbers= sum([a*b for a,b in zip(numbers,weights)])
weights = sum(weights)
print(round(numbers/weights,1))
