function solve() {
  let input = document.getElementById('text').value;
  let convention = document.getElementById('naming-convention').value;
  let result = '';
  
  let arr = input.split(' ');

  if (convention === 'Camel Case') {
    result += (arr[0][0].toLowerCase() + arr[0].substring(1).toLowerCase());
  } else if (convention === 'Pascal Case'){
    result += (arr[0][0].toUpperCase() + arr[0].substring(1).toLowerCase());
  } else {
    result = 'Error!';
  }

  if (result !== 'Error!') {
    for (let i = 1; i < arr.length; i++) {
      result += (arr[i][0].toUpperCase() + arr[i].substring(1).toLowerCase());
    }
  }

  document.querySelector('#result').textContent = result;
}