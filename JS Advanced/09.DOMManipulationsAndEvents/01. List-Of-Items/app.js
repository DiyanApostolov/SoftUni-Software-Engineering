function addItem() {
    let inputElement = document.getElementById('newItemText');
    let itemsElement = document.getElementById('items');

    let liElement = document.createElement('li');
    liElement.textContent = inputElement.value;

    itemsElement.appendChild(liElement);
}