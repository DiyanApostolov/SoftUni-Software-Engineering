function solve (fruit, grams, price){
    let money = (grams / 1000) * price;
    let weight = grams / 1000;

    console.log(`I need $${money.toFixed(2)} to buy ${weight.toFixed(2)} kilograms ${fruit}.`);
}