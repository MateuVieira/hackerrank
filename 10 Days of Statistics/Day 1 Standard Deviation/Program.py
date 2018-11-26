# Enter your code here. Read input from STDIN. Print output to STDOUT

size = int(input())
numbers = list(map(int, input().split()))

mean = sum(numbers)//size
standard_deviation= sum([((a - mean) ** 2) for a in numbers])/size
print(round(standard_deviation ** 0.5,1))