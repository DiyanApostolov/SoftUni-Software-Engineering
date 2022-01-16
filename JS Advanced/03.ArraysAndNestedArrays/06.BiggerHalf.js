function solve(arr) {
    let result = arr.sort((a, b) => a - b);
    let half = Math.floor(arr.length / 2);
    result.splice(0, half);

    return result;
}
