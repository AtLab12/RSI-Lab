
let address = "http://10.8.0.6:10000/Service1.svc/";

$(document).ready(function () {
    $('#getAllButton').click(function () {
        var format = $('#format-select').val();
        $.ajax({
            url: address + format + '/People',
            type: 'GET',
            success: function (data) {
                if (format === 'json') {
                    $('#getAllResult').text(JSON.stringify(data));
                } else if (format === 'xml') {
                    var serializer = new XMLSerializer();
                    var xmlString = serializer.serializeToString(data);
                    $('#getAllResult').text(xmlString)
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $('#getAllResult').text('Error - ' + jqXHR.status + ': ' + errorThrown);
            }
        });
    });

    $('#getIdButton').click(function () {
        var format = $('#format-select').val();
        var id = $('#getIdInput').val();

        $.ajax({
            url: address + format + '/People/' + id,
            type: 'GET',
            success: function (data) {
                if (format === 'json') {
                    $('#getIdResult').text(JSON.stringify(data));
                } else if (format === 'xml') {
                    var serializer = new XMLSerializer();
                    var xmlString = serializer.serializeToString(data);
                    $('#getIdResult').text(xmlString);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $('#getIdResult').text('Error - ' + jqXHR.status + ': ' + errorThrown);
            }
        });
    });

    $(document).ready(function () {
        $('#getNameButton').click(function () {
            var format = $('#format-select').val();
            var name = $('#getNameInput').val();
            $.ajax({
                url: address + format + '/People/ByName/' + name,
                type: 'GET',
                success: function (data) {
                    if (format === 'json') {
                        $('#getNameResult').text(JSON.stringify(data));
                    } else if (format === 'xml') {
                        var serializer = new XMLSerializer();
                        var xmlString = serializer.serializeToString(data);
                        $('#getNameResult').text(xmlString);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    $('#getNameResult').text('Error - ' + jqXHR.status + ': ' + errorThrown);
                }
            });
        });
    });

    $(document).ready(function () {
        $('#addPersonButton').click(function () {
            var format = $('#format-select').val();
            var newPerson;
            var contentType;
            if (format === 'json') {
                newPerson = {
                    name: $('#addPersonName').val(),
                    age: parseInt($('#addPersonAge').val()),
                    email: $('#addPersonEmail').val()
                };
                newPerson = JSON.stringify(newPerson);
                contentType = 'application/json';
            } else {
                newPerson = '<Person xmlns="http://schemas.datacontract.org/2004/07/MyWebService">' +
                    '<name>' + $('#addPersonName').val() + '</name>' +
                    '<age>' + $('#addPersonAge').val() + '</age>' +
                    '<email>' + $('#addPersonEmail').val() + '</email></Person>';
                contentType = 'application/xml';
            }
            $.ajax({
                url: address + format + '/People',
                type: 'POST',
                data: newPerson,
                contentType: contentType,
                success: function (data) {
                    $('#addPersonResult').text('Person added successfully.');
                    $('#addPersonName').val('');
                    $('#addPersonAge').val('');
                    $('#addPersonEmail').val('');
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    $('#addPersonResult').text('Error - ' + jqXHR.status + ': ' + errorThrown);
                }
            });
        });
    });

    $(document).ready(function () {
        $('#deletePersonButton').click(function () {
            var format = $('#format-select').val();
            var id = $('#deletePersonId').val();
            $.ajax({
                url: address + format + '/People' + id,
                type: 'DELETE',
                success: function (data) {
                    $('#deletePersonResult').text('Person deleted successfully.');
                    $('#deletePersonId').val('');
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    $('#deletePersonResult').text('Error - ' + jqXHR.status + ': ' + errorThrown);
                }
            });
        });
    });

    $(document).ready(function () {
        $('#editPersonButton').click(function () {
            var format = $('#format-select').val();
            var id = $('#editPersonId').val();
            var newPerson;
            var contentType;
            if (format === 'json') {
                newPerson = {
                    name: $('#editPersonName').val(),
                    age: parseInt($('#editPersonAge').val()),
                    email: $('#editPersonEmail').val()
                };
                newPerson = JSON.stringify(newPerson);
                contentType = 'application/json';
            } else {
                newPerson = '<Person xmlns="http://schemas.datacontract.org/2004/07/MyWebService">' +
                    '<name>' + $('#editPersonName').val() + '</name>' +
                    '<age>' + $('#editPersonAge').val() + '</age>' +
                    '<email>' + $('#editPersonEmail').val() + '</email></Person>';
                contentType = 'application/xml';
            }
            $.ajax({
                url: address + format + '/People' + id,
                type: 'PUT',
                data: newPerson,
                contentType: contentType,
                success: function (data) {
                    $('#editPersonResult').text('Person edited successfully.');
                    $('#editPersonId').val('');
                    $('#editPersonName').val('');
                    $('#editPersonAge').val('');
                    $('#editPersonEmail').val('');
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    $('#editPersonResult').text('Error - ' + jqXHR.status + ': ' + errorThrown);
                }
            });
        });
    });

    $(document).ready(function () {
        $('#getCountButton').click(function () {
            var format = $('#format-select').val();
            $.ajax({
                url: address + format + '/People/count',
                type: 'GET',
                success: function (data) {
                    if (format === 'json') {
                        $('#getCountResult').text(JSON.stringify(data));
                    } else if (format === 'xml') {
                        var serializer = new XMLSerializer();
                        var xmlString = serializer.serializeToString(data);
                        $('#getCountResult').text(xmlString)
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    $('#getCountResult').text('Error - ' + jqXHR.status + ': ' + errorThrown);
                }
            });
        });
    });


});



