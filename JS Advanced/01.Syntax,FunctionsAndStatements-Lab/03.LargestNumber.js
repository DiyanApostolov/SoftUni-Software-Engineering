function solve (x, y, z){
    let result;
    if (x > y && x > z) {
        result = x;
    }

    if (y > x && y > z) {
        result = y;
    }

    if (z > y && z > x) {
        result = z;
    }

    console.log(`The largest number is ${result}.`);
}
