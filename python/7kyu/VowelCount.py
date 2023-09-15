def get_count(sentence):
    vowelCounter = 0
    for i in range(len(sentence)):
        if (sentence[i] == "a" or sentence[i] == "e" or
            sentence[i] == "i" or sentence[i] == "o" or
            sentence[i] == "u"):
            vowelCounter += 1
    return vowelCounter
