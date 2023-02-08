//const bootstrap = require("../lib/bootstrap/dist/js/bootstrap");

$(document).ready(() => {
    console.log('CMSSite script loaded.')


});

const liveToastMessage = (message, origin) => {
    $('#toast-body').html(message);
    $('#toast-origin').html(origin);
    $('#toast-time').html(new Date().toLocaleTimeString('pt-BR', {
        hour12: false,
        hour: "numeric",
        minute: "numeric"
    }));
    const toastLiveMessages = $('#liveToast');
    const toast = new bootstrap.Toast(toastLiveMessages)

    toast.show()
}

const msgModalMessage = (message, callback) => {
    $('#modal-body').html(message);
    $('#btnModalCallback').click(() => callback());

    $('#msgModal').modal('show');
}

const closeMsgModalMessage = () => {
    $('#msgModal').modal('hide');
}