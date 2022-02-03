function notify(message) {
  let notification = document.getElementById('notification');
  notification.innerText = message;

  notification.style.display = 'block';

  //setTimeout(()=>{notification.style.display = 'none'}, 2000)

  notification.addEventListener('click', (event)=>{
    event.target.style.display = 'none';
  })
}