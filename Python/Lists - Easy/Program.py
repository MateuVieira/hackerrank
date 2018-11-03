if __name__ == '__main__':
    N = int(input())
    
    FUN = {
        "insert": lambda lst, i, e: lst.insert(i, e),
        "print": lambda lst: print(lst),
        "remove": lambda lst, e: lst.remove(e),
        "append": lambda lst, e: lst.append(e),
        "sort": lambda lst: lst.sort(),
        "pop": lambda lst: lst.pop(),
        "reverse": lambda lst: lst.reverse(),
    }
    
    lst = []
    
    for _ in range(N):
        cmd, *args = input().split()
        args = [int(a) for a in args]
        FUN[cmd](lst, *args)