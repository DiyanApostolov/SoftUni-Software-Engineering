function solve (arr){
    let numbers = arr;
    let result = '';
    for (let i = 0; i < numbers.length; i++) {
        if (i % 2 === 0) {
            result += numbers[i] + ' ';
        }
    }
    return result;
}
