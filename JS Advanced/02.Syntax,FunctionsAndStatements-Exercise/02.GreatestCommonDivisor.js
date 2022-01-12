function solve (n, m){
    const min = Math.min(n, m);
    let gcd = 1;

    for (let i = 1; i <= min; i++) {
        if (n % i == 0 && m % i == 0) {
            gcd = i;
        }
    }

    console.log(gcd);
}
