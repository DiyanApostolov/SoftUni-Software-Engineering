function solve (arr){
    let sum = 0;
    let inverseValueSum = 0;
    let print = '';

    for (let index = 0; index < arr.length; index++) {
        sum += Number(arr[index]);
        inverseValueSum += 1 / arr[index];
        print += arr[index];
        
    }

    console.log(sum);
    console.log(inverseValueSum);
    console.log(print);
}
