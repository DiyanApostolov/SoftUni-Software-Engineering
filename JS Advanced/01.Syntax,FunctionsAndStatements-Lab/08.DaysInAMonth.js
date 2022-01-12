function solve (month, year){
    function daysInMonth (m, y) {
        return new Date(y, m, 0).getDate();
    }

    console.log(daysInMonth(month, year));
}
