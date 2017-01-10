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