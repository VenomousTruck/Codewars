def digitize(n):
    s = str(n)[::-1]
    arr = [len(s)]

    for i in range(len(s)):
        arr.append(int(s[i]))

    return arr[1::]
