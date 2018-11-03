if __name__ == '__main__':
    n = int(input())
    arr = [[input(), float(input())] for _ in range(n)]

    c = sorted(set([b for a,b in arr]))[1]

    print ('\n'.join(sorted([a for a,b in arr if b == c])))

