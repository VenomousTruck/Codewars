function solution(str) {
    let splitStr = str.split("");
    let reversedArr = splitStr.reverse();
    let reversedStr = reversedArr.join("");
    return reversedStr;
}
