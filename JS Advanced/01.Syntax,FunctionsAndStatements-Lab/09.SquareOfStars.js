function solve (n){
    let array = [];

    for (let row = 0; row < n; row++) {
        for (let col = 0; col < n; col++) {
            array.push('*');
        }
        console.log(array.join(' '));
        array = [];
    }
}
