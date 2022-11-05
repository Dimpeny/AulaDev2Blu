/* #Confs */
const scripts = $('#scripts');

/* #Functions */
const getPagina = (url, target) => {
    $.ajax({
        url: `_views/${url}`,
        dataType: 'html',
        success: (pagina) => {
            $(target).html(pagina);
        }
    })
}

const getPokemon = () => {
    getPagina('getPokemon.html','main');
    $.ajax({
        url: URL_API,
        dataType: 'json',
        success: (data) => {
            let listPkm = document.createElement('ul');
            $(listPkm).addClass('list-group');
            data.forEach(p => {
                let li = document.createElement('li');
                let card = document.createElement('div');
                let cardHeader = document.createElement('div');
                let cardBody = document.createElement('div');

                $(card).addClass('card');
                $(cardHeader).addClass('card-header');
                $(cardBody).addClass('card-body');

                $(cardHeader).attr('id',`ch-pkm${i}`)
                getDataPokemon(p.url)
                
                $(cardBody).html(`<h1>${p.name}</h1>`);

                $(li).addClass('list-group-item');
            });
        }
    })
}

const getPhotoPokemon = (url) =>{
    return $.ajax({
        url:'',
        dataType: 'json',
        success: (data)=> data
        
    });
}

const getDataPokemon = (url, target) =>{
    return $.ajax({
        url:'',
        dataType: 'json',
        success: (data)=> {
            let dataHtml = document.createElement('img');
            $(dataHtml).addClass('card-img-top');
            $(target).html(dataHtml);
        }
        
    });
}