#!/bin/python3

N = int(input())

if( N%2 != 0 or 6 <= N and N <= 20):
    print("Weird")
elif( 2 <= N and N < 5 or N > 20):
    print("Not Weird")