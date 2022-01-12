function solve(n, m) {
    let num1 = Number(n);
    let num2 = Number(m);

    let result = 0;

    for (let index = num1; index <= num2; index++) {
        result += index;
    }

    console.log(result);
}
