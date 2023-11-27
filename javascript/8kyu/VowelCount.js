function getCount(str) {
    let matches = str.match(/[aeiou]/g);
    let count = matches ? matches.length : 0;
    return count;
}
