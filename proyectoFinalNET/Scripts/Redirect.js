/*Metodos de almacenamiento*/
function guardar() {
    $(document).ready(function () {
       
        var nombre_mascota = $('#nombreMascota').val();
        var codigo_tipo_mascota = $("#tipoMascota").val();
        var numero_chip = $("#numeroChip").val();
        var nombre_dueno = $("#nombreDueno").val();
        var rut_dueno = $("#rutDueno").val();
       
        $.ajax({
            url: '../Mascotas/nuevaMascota',
            type: 'POST',
            dataType: 'html',
            contentType: 'application/x-www-form-urlencoded',
            data: { "nombre_mascota": nombre_mascota, "codigo_tipo_mascota": codigo_tipo_mascota, "numero_chip": numero_chip, "nombre_dueno": nombre_dueno, "rut_dueno": rut_dueno },

            success: function (response) {
                alert("paso");
            }

        });
    });
}

function buscarMascotas(){
    $(document).ready(function () {

        var rut = $("#rut_dueno").val();

        if (rut === "")
        {
            alert("No puedes Tener Campos Vacios");
        }
        else {

            $.ajax({

                url:'../Mascotas/getMascotasDueno',
                type: 'post',
                dataType: 'html',
                contentType: 'application/x-www-form-urlencoded',
                data: { "rut": rut },
                success: function (response) {
                    $("#divCombo").empty();
                    $("#divCombo").html('' + response);
                }

            });
        }
    });
}

function GuardarVeterinario() {
    var nombre = $("#name").val();
    var dir = $("#dir").val();
    var email = $("#email").val();
    var pass = $("#pass").val();
    if (nombre === '' || dir === '' || email === '' || pass === '') {
        alert("complete los campos");
    } else {
        $.ajax({
            url: '',
            type: 'post',
            dataType: 'html',
            contentType: 'application/x-www-form-urlencoded',
            data: {
                "nombre": nombre,
                "dir": dir,
                "email": email,
                "pass": pass
            },
            success: function (response) {
                alert("Almacenado Correctamente");
            }

        });
    }
}
/*Redirect paginas*/
function VolverMenu() {

}