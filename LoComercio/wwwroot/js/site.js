// Write your Javascript code.
function Mayusculas() {
    javascript: this.value = this.value.toUpperCase();
};

jQuery(function ($) {
    $("#tel").mask("(999)999-9999");
    $("#tel0").mask("(999)999-9999");
});

var config = {
    '.chosen-select': {},
    '.chosen-select-deselect': { allow_single_deselect: true },
    '.chosen-select-no-single': { disable_search_threshold: 10 },
    '.chosen-select-no-results': { no_results_text: 'Oops, nothing found!' },
    '.chosen-select-width': { width: "95%" }
}
for (var selector in config) {
    $(selector).chosen(config[selector]);
}



function VerificaAccesorios() {
    if ($("#DejaAccesorios").is(":checked")) {
        $("#DescripcionAccesorios").prop("disabled", false);
    }
    else {
        $("#DescripcionAccesorios").prop("disabled", true);
    }
};

function VerificaRevisionAdicional() {
    if ($("#RevisionAdicional").is(":checked")) {
        $("#DescripcionRevisionAdicional").prop("disabled", false);
    }
    else {
        $("#DescripcionRevisionAdicional").prop("disabled", true);
    }
};

function Desbloqueo()
{
    if($("#pd1").is(":checked"))
    {
        $("#PasswordDesbloqueo").prop("disabled", false);
    }else
    {
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
    }else
    {
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


function BuscarModelo(id) {
    $.post("../../OrdenServicios/BuscarModelo/" + id, function (data) {
        // extract values from data object and assign ut to your controls
        console.log('Post invocado /OrdenServicios/BuscarModelo/' + id + '?')
        console.log(data);
        $('#IdModeloT').val(data.nombre);
    });
}
