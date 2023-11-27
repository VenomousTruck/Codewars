function descendingOrder(n) {
    str = new String(n);
    arr = str.split("").sort().reverse();
    newStr = arr.toString().replaceAll(",", "");
    return parseInt(newStr);
}

console.log(descendingOrder(12456709));