var Cliente = {
    
    CargaCliente: function (idCliente) {

        var url =  "/Cliente/Detalle/" + idCliente; // El url del controlador
        $.get(url, function (data) {
            $('#actualiza-Cliente').html(data);
            $('#actualiza-Cliente').modal({
                backdrop: 'static',
                keyboard: true
            }, 'show');

        });
    }

}