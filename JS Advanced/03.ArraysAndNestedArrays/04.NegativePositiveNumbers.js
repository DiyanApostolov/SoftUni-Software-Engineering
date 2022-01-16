function solve(arr) {
    let result = [];
    arr.forEach(element => {
        if (Number(element) < 0) {
            result.unshift(element);
        } else {
            result.push(element);
        }
    });

    return result.join('\n');
}
