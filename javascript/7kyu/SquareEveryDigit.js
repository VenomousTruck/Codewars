function squareDigits(num){
    str = new String(num);
    newStr = "";

    for (i = 0; i < str.length; i++) {
        newStr += str[i] ** 2;
    }

    return parseInt(newStr);
}
