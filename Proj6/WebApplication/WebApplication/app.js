
var address = "http://localhost:10000/Service1.svc/";
$(document).ready(function () {
    $('#getAllButton').click(function () {
        var format = $('#format-select').val();
        $.ajax({
            url: address + format + '/People',
            type: 'GET',
            success: function (data) {
                // Display the result in the corresponding result cell
                $('#getAllResult').text(JSON.stringify(data));
            },
            error: function (error) {
                // Display the error message
                $('#getAllResult').text('Error: ' + error);
            }
        });
    });
});

