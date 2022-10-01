const URL = 'https://localhost:7214/Product'

const container = document.querySelector('table.listUrl');

getData(URL)


function getData(url){
    fetch(url)
        .then(res => {
        return res.json()
    })
        .then((data) => {
            data.map((p) => {
                let createTable = document.createElement('tr')
                let productName = document.createElement('td')
                let productPrice = document.createElement('td')
                let productCategory = document.createElement('td')

                productName.classList.add(p.id)
                productName.textContent = p.name

                productPrice.classList.add(p.id)
                productPrice.textContent = p.price.toLocaleString('ru') + ' ₽'

                productCategory.classList.add(p.category)
                productCategory.textContent = p.category

                if (container){
                    container.appendChild(createTable)
                }
                createTable.append(productName,productPrice,productCategory)
            })
        })
}