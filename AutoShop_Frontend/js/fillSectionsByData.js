async function fillSections() {
    let list = document.querySelector('main');
	try {
	  const response = await fetch('http://localhost:8080/api/details');
	  const data = await response.json();
	  
	  Object.entries(data).forEach(entry => {
        const [key, value] = entry;
        const section = createSection(key);
          value.forEach(
            obj => {
              section.append(createCard(obj));
            }
          )
          list.appendChild(section);
        })
  
	} catch (error) {
	  console.error('Error:', error);
	}
    function createSection(key)
  {
    let h = document.createElement("H2");
    let t = document.createTextNode(key);
    h.appendChild(t);
    list.appendChild(h);
    let newDiv = document.createElement('div');
        newDiv.classList.add('products', 'container');
        return newDiv;
  }

  function createCard(obj)
  {
    let newDiv = document.createElement('div');
        newDiv.classList.add('product__element');
        newDiv.innerHTML = `
        <input type="hidden" name="" id="product__id" value="${obj.id}" />
        <img src="${obj.imgSrc}" alt="" srcset="" id="image" />
        <h4 class="product__name">${obj.name}</h4>
        <h5 class="product__price">грн ${obj.price}</h5>
        <div class="btn__add__to__cart">Додати у кошик</div>`;
        return newDiv;
  }
}