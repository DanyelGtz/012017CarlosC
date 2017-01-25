
// Write your Javascript code.
function Mayusculas() {
    javascript: this.value = this.value.toUpperCase();
};

jQuery(function ($) {
    $("#tel").mask("(999)999-9999");
    $("#tel0").mask("(999)999-9999");
});


function VerificaAccesorios() {
    if ($("#DejaAccesorios").is(":checked")) {
        $("#DescripcionAccesorios").prop("disabled", false);
    }
    else {
        $("#DescripcionAccesorios").prop("disabled", true);
    }
};

function CopiarTelefonoCliente() {
    var valor = $('#tel').val();
    $('#tel0').val(valor);
};

function VerificaRevisionAdicional() {
    if ($("#RevisionAdicional").is(":checked")) {
        $("#DescripcionRevisionAdicional").prop("disabled", false);
    }
    else {
        $("#DescripcionRevisionAdicional").prop("disabled", true);
    }
};

function Desbloqueo() {
    if ($("#pd1").is(":checked")) {
        $("#PasswordDesbloqueo").prop("disabled", false);
    } else {
        $("#PasswordDesbloqueo").prop("disabled", true);
    }

    if ($("#pd2").is(":checked")) {
        $("#PatronDesbloqueo").prop("disabled", false);
    } else {
        $("#PatronDesbloqueo").prop("disabled", true);
    }

}

function ValidarColorPieza() {
    //Validar color de pieza
    var tipoServicio = document.getElementById("IdTipoServicio").value;
    if (tipoServicio == 1) {
        $("#ColorPieza").prop("disabled", false);
        $("#ColorPieza").prop("required", true);
    } else {
        $("#ColorPieza").prop("disabled", true);
        $("#ColorPieza").prop("required", false);
    }
};
function BuscarModeloTecnico(id) {
    $.post("../../OrdenServicios/BuscarModeloTecnico/" + id, function (data) {
        // extract values from data object and assign ut to your controls
        console.log('Post invocado /OrdenServicios/BuscarModeloTecnico/' + id + '?');
        console.log(data);
        $('#IdModelo').prop("disabled", false);

        $('#IdModelo').find('option').remove().end();
        $('#IdModelo').append('<option value="Seleccionar">Seleccionar</option>').val('Seleccionar');
        $.each(data, function (i, item) {
            $('#IdModelo').append($('<option>', {
                value: item.id,
                text: item.modeloTecnico
            }));
        });
    });

};


function BuscarModeloComercial(id) {
    $.post("../../OrdenServicios/BuscarModeloComercial/" + id, function (data) {
        // extract values from data object and assign ut to your controls
        console.log('Post invocado /OrdenServicios/BuscarModeloComercial/' + id + '?');
        console.log(data);
        $('#IdModelo').prop("disabled", false);

        $('#IdModelo').find('option').remove().end();
        $('#IdModelo').append('<option value="Seleccionar">Seleccionar</option>').val('Seleccionar');
        $.each(data, function (i, item) {
            $('#IdModelo').append($('<option>', {
                value: item.id,
                text: item.modeloTecnico
            }));
        });
    });

};


function BuscarModelo(id) {
    $.post("../../OrdenServicios/BuscarModelo/" + id, function (data) {
        // extract values from data object and assign ut to your controls
        console.log('Post invocado /OrdenServicios/BuscarModelo/' + id + '?')
        console.log(data);
        $('#IdModeloT').val(data.nombre);
    });
}


function ObtenerTecnicosJson() {
    $.post("../../Tecnicos/ObtenerTecnicosJson/", function (data) {
        // extract values from data object and assign ut to your controls
        console.log('Post invocado /Tecnicos/ObtenerTecnicosJson/?');
        console.log(data);
        $('#idTecnico').prop("disabled", false);

        $('#idTecnico').find('option').remove().end();
        $('#idTecnico').append('<option value="Seleccionar">Seleccionar</option>').val('Seleccionar');
        $.each(data, function (i, item) {
            $('#idTecnico').append($('<option>', {
                value: item.id,
                text: item.nombre
            }));
        });
    });

};

function ConfigurarSelects() {
    $(".chosen-select").chosen({
        search_contains: true
    });
    
}


function ObtenerServiciosJson() {
    $.post("../../Servicios/ObtenerServiciosJson/", function (data) {
        // extract values from data object and assign ut to your controls
        console.log('Post invocado /Servicios/ObtenerServiciosJson/?');
        
        $('#IdServicio').find('option').remove().end();
        $('#IdServicio').append('<option value="Seleccionar">Seleccionar</option>').val('Seleccionar');

        $.each(data, function (i, item) {
            $('#IdServicio').append($('<option>', {
                value: item.id,
                text: item.nombre
            }));
        });
        $(".chosen-select").trigger('chosen:updated');
        console.log(data);
    });
};

function ObtenerCostosServicioJson(id) {
    $.post("../../Servicios/ObtenerCostosServicioJson/" + id, function (data) {
        // extract values from data object and assign ut to your controls
        console.log('Post invocado /Servicios/ObtenerCostosServicioJson/' + id + '?');
        console.log(data);
        if (data != null) {
            $('#precioSugerido').val(data.precioSugerido);
            $('#precioMinimo').val(data.precioMinimo);
            $('#precioMaximo').val(data.precioMaximo);
        } else {
            $('#precioSugerido').val('0');
            $('#precioMinimo').val('0');
            $('#precioMaximo').val('0');
        }
    });

};