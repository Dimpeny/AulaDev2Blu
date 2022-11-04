// Variáveis
const URL_VIACEP = "https://viacep.com.br/ws/@CEP/json/";

addEventListener("load", (e) => {
  console.log("Sistema carregando");
  $("#bloco").style.display = "none";

  //Registra evento CEP
  $("#cep").addEventListener("blur", (e) => {
    var valorCampo = e.target.value;
    console.log(`O valor digitado foi '${valorCampo}'`);
    if (valorCampo.length >= 8) {
      $("#endereco").style.display = "block";
      var urlCep = URL_VIACEP.replace("@CEP", valorCampo);
      getJson(urlCep).then((resp) => {
        console.log(resp);
        $("#rua").value = resp.logradouro;
        $("#bairro").value = resp.bairro;
        $("#cidade").value = resp.localidade;
        $("#uf").value = resp.uf;
        e.target.value = resp.cep;
        $("#numero").focus();
      });
    }
  });
});

const validaFormulario = () => {
  if ($("#nome").value === "") return false;
};

function getJson(url) {
  return fetch(url).then((resposta) => resposta.json());
}

function $(queryselector) {
  return document.querySelector(queryselector);
}

// var nome, idade;
//
// // nome = prompt("Informe seu nome");
// // console.log(`Nome: ${nome}`);

// // nome = prompt("Informe sua idade");
// // console.log(`Idade: ${idade}`);

// var bloco = document.getElementById('bloco');
// bloco.addEventListener('mouseover',function(e){
//     bloco.style.marginLeft = '5em';
//     bloco.style.backgroundColor = 'yellow';
// });
// bloco.addEventListener('mouseout',function(e){
//     bloco.style.marginLeft = '1em';
//     bloco.style.backgroundColor = 'blue';
// })

// var textBloco = document.querySelector('#bloco span');
// textBloco.getElementsByClassName.color= '#fff';
