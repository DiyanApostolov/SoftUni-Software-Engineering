class Circle {
    constructor(radius){
        this.radius = Number(radius);
    }

    set diameter(value){
        this.radius = value / 2;
    };

    get diameter(){
        return this.radius * 2;
    };

    get area(){
        return Math.PI * (this.radius ** 2);
    };
}


let kolelo = new Circle(5);
kolelo.diameter = 1.6;
console.log(kolelo.radius);
console.log(kolelo.diameter);
console.log(kolelo.area().toFixed(2));