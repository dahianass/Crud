$(document).ready(function () {
    var url = 'http://localhost:63580';
    $('#SaveUsuarios').click(function () {
        guardarPersona();
    });

    function guardarPersona() {
        var usuarios = {
            Nombre: 'Michael',
            Apellido: 'Saldarriaga',
            Documento: '45678',
            Cargo: 'Analista' ,
            CorreoElectronico:'cargo@cargo.com',
            Password:'09876',
            IdRol: 1,
            Active: true,
        };

        var objUsuario = JSON.stringify(usuarios);
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: url + '/odata/Usuarios',
            data: objUsuario,
            success: function (response) {
                console.log(response);
                alert("Guardado");
            },
            failure: function (response) {
                console.log(response);
            }
        });
    }
    function ListarPersonas() {
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'GET',
            url: url + '/odata/Usuarios',
            //data: { 'code': code },
            success: function (response) {
                console.log("entro", response);
            },
            failure: function (response) {
                console.log(response);
            }
        });
    }
    function ListarPersonas(id) {
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'GET',
            url: url + '/odata/Usuarios(' + id + ')',
            //data: { 'code': code },
            success: function (response) {
                console.log("entro", response);
            },
            failure: function (response) {
                console.log(response);
            }
        });
    }
    ListarPersonas();
    ListarPersonas(1);
});

