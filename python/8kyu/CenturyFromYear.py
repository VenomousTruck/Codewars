def century(year):
    age = 100
    century = 1

    for i in range(age, year, age):
        century += 1
    return century
