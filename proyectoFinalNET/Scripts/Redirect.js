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
                alert("paso");
            }

        })

    });
}