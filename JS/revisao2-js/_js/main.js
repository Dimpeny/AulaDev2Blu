var listCharacter = new Array();

addEventListener("load", function () {
  getAPI(URL_API_CHARACTER, criaListaCharacter);
});

const criaListaCharacter = (data) => {
  let main = getElement("main");
  console.log(data);
  data.results.forEach((character) => {
    let html = document.createElement("div");
    html.classList.add("card", "col-2", "my-4", "bg-dark");
    html.addEventListener("click", () => mostraDetalheCharacter(character));
    let htmlBody = `
        <div class="card-header">
            <img class="card-img-top" src="${character.image}" alt="${character.name}">
        </div>
        <div class="card-body bg-white">
            <h1 class="text-primary text-center">${character.name}</h1>
        </div>`;

    html.innerHTML = htmlBody;
    main.appendChild(html);
    listCharacter.push(character);
  });

  
  gerarPaginacao(data.info);
};

const mostraDetalheCharacter = (character) => {
  console.log(character);
  let div = document.createElement("div");
  getElement("#modal-body").innerHTML = "";
  div.classList.add("card", "col-12", "my-4");
  let cardBody = `<div class="card col-12 my-4">
    <div class="card-header">
      <img
        class="card-img-top"
        src="${character.image}"
        alt="Rick"
      />
    </div>
    <div class="card-body">
      <hi class="text-primary text-center">${character.name}</hi>
      <article>
        <ul class="list-group">
          <li class="list-group-item">Status: ${character.status}</li>
          <li class="list-group-item">Species: ${character.species}</li>
          <li class="list-group-item">Type: ${character.type}</li>
          <li class="list-group-item">Gender: ${character.gender}</li>
          <li class="list-group-item">Origin: ${character.origin.name}</li>
          <li class="list-group-item">Location: ${character.location.name}</li>
          <li class="list-group-item">Url: ${character.url}</li>
          <li class="list-group-item">Created: ${character.created}</li>
        </ul>
      </article>
    </div>
  </div>`;
  div.innerHTML = cardBody;
  getElement("#modal-body").appendChild(div);
  $("#charModal").modal("show");


  const chara = {
    id: character.id,
    name: character.name,
    status: character.status,
    species: character.species,
    type: character.type,
    gender: character.gender,
    origin: character.origin,
    location: character.location,
    image: character.image,
    episode: character.episode,
    url: character.url,
    created: character.created,
  };
};

const gerarPaginacao = (info) => {
  let pag = getElement("#pagination");
  let liItem = document.createElement("li");
  liItem.classList.add("page-item");

  let prevItem = { ...liItem };

  prevItem.innerHTML = `<a inclick="irItemPaginacao(${info.prev})" class="page-link" href="#">Previous</a>`;
  pag.appendChild(liItem);

  for (let index = 0; index < pag.pages; index++) {
    let liItemPag = { ...liItem };
    liItemPag.innerHTML;
    prevItem.innerHTML = `<a inclick="irItemPaginacao(${URL_API_CHARACTER}?page=${
      index + 1
    })" class="page-link" href="#">${index + 1}</a>`;
  }
  let nextItem = liItem;
  nextItem.classList.add("page-item");
  nextItem.innerHTML = `<a inclick="irItemPaginacao(${info.prev})" class="page-link" href="#">Previous</a>`;
  pag.appendChild(liItem);
};

const novoItemPagination =(url,index) =>{

}

const irItemPaginacao = (url) => {};

