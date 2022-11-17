var listPeixe = new Array();

addEventListener("load", function () {
  getAPI(URL_API_PEIXE, criaListaPeixe);
});

const criaListaPeixe = (data) => {
  let main = getElement("main");
  console.log(data);
  listPeixe = new Array();

  data.forEach((peixe) => {
    console.log(data);
    let html = document.createElement("div");
    html.classList.add("col-4", "my-4","bg-dark","px-2","container");
    html.addEventListener("click", () => mostraDetalhesPeixe(peixe));

    var cardHeader;

    try {
      cardHeader = `
        <div class="card-header bg-light">
            <img class="card-img-top" src="${peixe["Species Illustration Photo"].src}" alt="Foto do peixe">
        </div>`;
    } catch (error) {
        cardHeader = `
        <div class="card-header bg-pink m-sm">
            <img class="card-img-top" src="_img/NoImageAvailable.png" alt="Foto do peixe">
        </div>`;
    }

    let htmlBody = `
    <div class="card bg-primary">
        ${cardHeader}
        <div class="card-body">
            <h2 class="text-light text-center">${peixe["Species Name"]}</h2>
        </div>
    </div>`;

    html.innerHTML = htmlBody;
    main.appendChild(html);
    listPeixe.push(peixe);
  });

  gerarPaginacao(data.info);
};

const mostraDetalhesPeixe = (peixe) => {
  console.log(peixe);
  let div = document.createElement("div");
  getElement("#modal-body").innerHTML = "";
  div.classList.add("card", "col-12", "my-4", "bg-primary");
  
  var cardHeader;

  try {
    cardHeader = `
      <div class="card-header bg-light">
          <img class="card-img-top" src="${peixe["Species Illustration Photo"].src}" alt="Foto do peixe">
      </div>`;
  } catch (error) {
      cardHeader = `
      <div class="card-header bg-pink m-sm">
          <img class="card-img-top" src="_img/NoImageAvailable.png" alt="Foto do peixe">
      </div>`;
  }

  let cardBody = `${cardHeader}
  <div class="card-body bg-info">
    <h1 class="text-primary text-center">${peixe["Species Name"]}</h1>
    <article>
      <ul class="list-group">
        <li class="list-group-item">
          <p>
            <button
              class="btn btn-primary"
              type="button"
              data-bs-toggle="collapse"
              data-bs-target="#collapseHabitat"
              aria-expanded="false"
              aria-controls="collapseHabitat"
            >
              Habitat
            </button>
          </p>
          <div>
            <div class="collapse" id="collapseHabitat">
              <div class="card card-body" style="width: 300px">
                ${peixe.Habitat}
              </div>
            </div>
          </div>
        </li>
        <li class="list-group-item">
          <p>
            <button
              class="btn btn-primary"
              type="button"
              data-bs-toggle="collapse"
              data-bs-target="#collapseHabitatImpacts"
              aria-expanded="false"
              aria-controls="collapseHabitatImpacts"
            >
            Habitat Impacts
            </button>
          </p>
          <div>
            <div class="collapse" id="collapseHabitatImpacts">
              <div class="card card-body" style="width: 300px">
                ${peixe["Habitat Impacts"]}
              </div>
            </div>
          </div>
        </li>
        <li class="list-group-item">
          <p>
            <button
              class="btn btn-primary"
              type="button"
              data-bs-toggle="collapse"
              data-bs-target="#collapseLocation"
              aria-expanded="false"
              aria-controls="collapseLocation"
            >
              Location
            </button>
          </p>
          <div>
            <div class="collapse" id="collapseLocation">
              <div class="card card-body" style="width: 300px">
                ${peixe.Location}
              </div>
            </div>
          </div>
        </li>

        <li class="list-group-item">
          <p>
            <button
              class="btn btn-primary"
              type="button"
              data-bs-toggle="collapse"
              data-bs-target="#collapseAvailability"
              aria-expanded="false"
              aria-controls="collapseAvailability"
            >
              Availability
            </button>
          </p>
          <div>
            <div class="collapse" id="collapseAvailability">
              <div class="card card-body" style="width: 300px">
                ${peixe.Availability}
              </div>
            </div>
          </div>
        </li>

        <li class="list-group-item">
          <p>
            <button
              class="btn btn-primary"
              type="button"
              data-bs-toggle="collapse"
              data-bs-target="#collapseFisheryManagement"
              aria-expanded="false"
              aria-controls="collapseFisheryManagement"
            >
              Fishery management
            </button>
          </p>
          <div>
            <div class="collapse" id="collapseFisheryManagement">
              <div class="card card-body" style="width: 300px">
                ${peixe["Fishery Management"]}
              </div>
            </div>
          </div>
        </li>
      </ul>
    </article>
  </div>`;
  div.innerHTML = cardBody;
  getElement("#modal-body").appendChild(div);

  $("#charModal").modal("show");
};
