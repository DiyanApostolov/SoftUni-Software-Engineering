function solve (n, k){
    let arr = [1];
    for (let i = 1; i < n; i++) {
        let currElement = 0;
        for (let j = 1; j <= k; j++) {
            if (i - j < 0) {
                continue;
            }
            currElement += Number(arr[i - j]);
        } 
        arr.push(currElement);
    }

    return arr.join(', ');
}
