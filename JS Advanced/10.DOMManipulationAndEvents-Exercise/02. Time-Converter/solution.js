function timeConverter() {

    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    document.getElementById('daysBtn').addEventListener('click', onConvert);
    document.getElementById('hoursBtn').addEventListener('click', onConvert);
    document.getElementById('minutesBtn').addEventListener('click', onConvert);
    document.getElementById('secondsBtn').addEventListener('click', onConvert);

    let rations = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400
    }; 

    function onConvert(event){
        console.log(event.target);
    }
}