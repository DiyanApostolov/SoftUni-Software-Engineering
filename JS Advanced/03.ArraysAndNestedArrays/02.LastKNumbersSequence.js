function solve (n, k){
    let arr = [1];
    for (let i = 1; i < n; i++) {
        let currElement = 0;
        for (let j = 1; j <= k; j++) {
            currElement += Number(arr[i - j]);
        } 
        arr.push(currElement);
    }

    console.log(arr.join(', '));
}

solve(6, 3);