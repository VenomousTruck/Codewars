function highAndLow(numbers){
    arr = numbers.split(" ").map((x) => parseInt(x));
    maximum = new String(Math.max(...arr));
    minimum = new String(Math.min(...arr));
    return new String(maximum) + " " + new String(minimum);
}
