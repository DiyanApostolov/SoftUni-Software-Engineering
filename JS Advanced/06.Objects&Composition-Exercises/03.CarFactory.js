function solve(car) {
    let volume = 0;

    if (car.power <= 90) {
        volume = 1800;
        car.power = 90;
    } else if(car.power <= 120) {
        volume = 2400;
        car.power = 120;
    } else if(car.power <= 200) {
        volume = 3500;
        car.power = 200;
    }

    if (car.wheelsize % 2 === 0) {
        car.wheelsize--;
    }
    
    let objCar = {
        model: car.model,
        engine: {
            power: car.power,
            volume: volume
        },
        carriage: {
            type: car.carriage,
            color: car.color
        },
        wheels: [car.wheelsize,car.wheelsize,car.wheelsize,car.wheelsize] 
    };

    return objCar;
}

solve({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 });