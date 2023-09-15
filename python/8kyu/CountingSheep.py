def count_sheeps(sheep):
    counter = 0
    for i in range(len(sheep)):
        if sheep[i] == True:
            counter += 1
    return counter
