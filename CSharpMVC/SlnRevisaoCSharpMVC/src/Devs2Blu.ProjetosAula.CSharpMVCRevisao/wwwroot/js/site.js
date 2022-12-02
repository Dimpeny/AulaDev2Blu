$(document).ready(() => {
    $("btn-search").click(() => {
        let nameInput = $("input-search").val();
        $.ajax({
            url: `/card/search?=${nameInput}`,
            dataType: 'html',
            success: (htmlPartialView) => {
                $('#content-list').html(htmlPartialView);
            }
        });
    });
});