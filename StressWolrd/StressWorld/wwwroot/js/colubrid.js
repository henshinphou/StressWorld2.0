function createFormCSV() {
    $.ajax({
        url: '/Colubrids/Create',
        type: 'POST',
        dataType: 'html',
        data: {
           
        }
    }).done(function (res) {
        debugger
    });
}
