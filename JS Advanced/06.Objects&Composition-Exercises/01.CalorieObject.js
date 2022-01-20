function solve(input){
    let obj = {};
    let indexL = input.length;

    for (let i = 0; i < indexL; i+=2) {
        let key = input[i];
        let value = Number(input[i + 1]);
        
        obj[key] = value;
    }

    console.log(obj);
}
