function tickets(arr, sortCriteria){
    class Ticket {
        constructor(destination, price, status){
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }

    const arrayOftickets = [];

    arr.forEach(item => {
        const [destination, price, status] = item.split('|');
        const currentTicket = new Ticket(destination, price, status);
        arrayOftickets.push(currentTicket);
    });

    return sortCriteria === 'price' ? arrayOftickets.sort((a, b) => a[sortCriteria] - b[sortCriteria]) 
                                      : arrayOftickets.sort((a, b) => a[sortCriteria].localeCompare(b[sortCriteria]));
}

console.log(tickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination'
));