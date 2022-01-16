function solve(arr) {
    let result = [];
    result.push(arr[0]);

    for (let i = 1; i < arr.length; i++) {
        let currElement = Number(arr[i]);
        if (currElement < result[0]) {
            result.unshift(currElement)
        } else if(currElement < result[1]) {
            result.splice(1, 1, currElement);
        } else {
            result.push(currElement)
        }
    }

    result.splice(2, result.length);

    return result.join(' ');
}

console.log(solve([1, 15, 5, 8]));