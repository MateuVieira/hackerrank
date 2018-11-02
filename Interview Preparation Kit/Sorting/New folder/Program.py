import bisect

def get_median(expd, d):
    if d % 2 == 1:
        return expd[int((d - 1) / 2)]
    else:
        return float((expd[int(d / 2)] + expd[int(d / 2) - 1])) / 2


def adjust_arr(arr, delete, add):
    arr.pop(bisect.bisect_left(arr, delete))
    bisect.insort(arr, add)
    
def qsort(L):
    if len(L) <= 1: return L
    return qsort([lt for lt in L[1:] if lt < L[0]]) + L[0:1] + \
           qsort([ge for ge in L[1:] if ge >= L[0]])
    
# Complete the activityNotifications function below.
def activityNotifications(expenditure, d):
    num = 0
    arr = qsort(expenditure[0:d])
    for i in range(d, len(expenditure)):
        if expenditure[i] >= 2 * get_median(arr, d):
            num += 1
        adjust_arr(arr, expenditure[i-d], expenditure[i])
    return num