def positive_sum(arr):
    if len(arr) == 0:
        return 0
    else:
        sum = 0
        for i in arr:
            if i > 0:
                sum += i
        return sum
