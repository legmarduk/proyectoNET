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
            contentType:'application/x-www-form-urlencoded',
            data: { "nombre_mascota": nombre_mascota, "codigo_tipo_mascota": codigo_tipo_mascota, "numero_chip": numero_chip, "nombre_dueno": nombre_dueno, "rut_dueno": rut_dueno },

            success: function (response) {
                
            }

        })

    });
}

function buscarMascotas(){
    $(document).ready(function () {

        var rut = $("#rut_dueno").val();
        if (rut === "")
        {
            alert("Rut vacio");
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

function BuscarHistorial() {
    
    $(document).ready(function () {


        var idMascota = $("#tipoMascota").val();

        console.log(idMascota);
        if (idMascota != 0) {
            $.ajax({

                url: '../Mascotas/getHistorialMascota',
                type: 'get',
                dataType: 'html',
                contentType: 'application/x-www-form-urlencoded',
                data: { "id": idMascota },
                success: function (response) {
                    console.log(response);
                    $("#divHistorial").html('' + response);
                }
            });
        }
        else {
            confirm("Debe Seleccionar una mascota");
        }
        
    });
}