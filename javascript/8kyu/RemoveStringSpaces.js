function noSpace(x) {
    x = x.replace(" ", "");

    let str = "";

    for (i = 0; i < x.length(); i++) {
        str += x[i];
    }

    return str;
}