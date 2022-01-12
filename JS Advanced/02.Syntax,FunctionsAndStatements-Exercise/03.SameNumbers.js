function solve (number){
    let areSame  = true;
    let sum = 0;

    const arr = Array.from(number.toString());

    for (let i = 0; i < arr.length - 1; i++) {
         
        if (areSame ) {
            if (arr[i] != arr[i + 1]) {
                areSame  = false;
            }
        }
        
        sum += Number(arr[i]);
    }
    sum += Number(arr[arr.length - 1]);

    console.log(areSame );
    console.log(sum);
}
