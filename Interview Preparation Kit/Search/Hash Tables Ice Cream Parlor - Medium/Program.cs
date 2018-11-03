#!/bin/python3

import math
import os
import random
import re
import sys

def print_sorted(x, y):
    if (x < y):
        print ("%d %d" % (x, y))
    else:
        print ("%d %d" % (y, x))
        
def whatFlavors(flavors, budget):
    p_map = {}
    
    for i in range(0, len(flavors)):
        if p_map.get(flavors[i], 0) == 0:
            p_map[flavors[i]] = [i+1]
        else:
            p_map[flavors[i]].append(i+1)
     
    for p in p_map:
        if (budget - p) in p_map:
            if p*2 == budget:
                if len(p_map[p]) > 1:
                    print_sorted(p_map[p][0], p_map[p][1])
            else:
                print_sorted(p_map[p][0], p_map[budget - p][0])
                return

if __name__ == '__main__':
    t = int(input())

    for t_itr in range(t):
        money = int(input())

        n = int(input())

        cost = list(map(int, input().rstrip().split()))

        whatFlavors(cost, money)

