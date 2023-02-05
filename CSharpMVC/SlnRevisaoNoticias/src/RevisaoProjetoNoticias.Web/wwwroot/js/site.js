const bootstrap = require("../lib/bootstrap/dist/js/bootstrap");

$(document).ready(() => {
    console.lof('CMSSite script loaded.')


});

liveToastMessage = () => {
    const origin = $('#toast-origin')
    const toastLiveMessages = $('#liveToast');
    if (toastTriger) {
        const toast = new bootstrap.Toast(toastLiveMessages);

        toast.show();

    }
}