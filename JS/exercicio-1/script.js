
addEventListener('load', (e)=>{
    $('#aba1').style.display = 'block';

    document.querySelector('#item-aba1')
        .addEventListener('click',(e)=>{
            $('#aba1').style.display = 'block';
            $('#aba2').style.display = 'none';
            $('#aba3').style.display = 'none';
            $('#aba4').style.display = 'none';
        });
    document.querySelector('#item-aba2')
        .addEventListener('click',(e)=>{
            $('#aba2').style.display = 'block';
            $('#aba1').style.display = 'none';
            $('#aba3').style.display = 'none';
            $('#aba4').style.display = 'none';
        });
    document.querySelector('#item-aba3')
        .addEventListener('click',(e)=>{
            $('#aba3').style.display = 'block';
            $('#aba2').style.display = 'none';
            $('#aba1').style.display = 'none';
            $('#aba4').style.display = 'none';
        });
    document.querySelector('#item-aba4')
        .addEventListener('click',(e)=>{
            $('#aba4').style.display = 'block';
            $('#aba2').style.display = 'none';
            $('#aba3').style.display = 'none';
            $('#aba1').style.display = 'none';
        });
});      



function $(q) {
    return document.querySelector(q);
}