function solve (first, second, third) {
    let firstLenght = first.lenght;
    let secondLenght = second.lenght;
    let thirdLenght = third.lenght;

    let sum = firstLenght + secondLenght + thirdLenght;
    let result = Math.floor(sum / 3);

    console.log(sum);
    console.log(result);
}

solve('chocolate', 'ice cream', 'cake');

