console.log('Script loaded');
var nome, idade;

// nome = prompt("Informe seu nome");
// console.log(`Nome: ${nome}`);

// nome = prompt("Informe sua idade");
// console.log(`Idade: ${idade}`);

var bloco = document.getElementById('bloco');
bloco.addEventListener('mouseover',function(e){
    bloco.style.marginLeft = '5em';
    bloco.style.backgroundColor = 'yellow';
});
bloco.addEventListener('mouseout',function(e){
    bloco.style.marginLeft = '1em';
    bloco.style.backgroundColor = 'blue';
})

var textBloco = document.querySelector('#bloco span');
textBloco.getElementsByClassName.color= '#fff';