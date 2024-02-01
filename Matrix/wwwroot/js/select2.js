
// Trade Warranty

$(document).ready(function () {
    $('.modelID').select2({
        dropdownParent: $('#exampleModalCenter'),
        ajax: {
            "url": "../JSON/select.json",
            dataType: 'json'
        }
    });

})



// Stock

$(document).ready(function () {
    $('.categorySelect').select2({
        dropdownParent: $('#ModalCenter'),
        ajax: {
            "url": "../JSON/select.json",
            dataType: 'json'
        }
    });

})


$(document).ready(function () {
    $('.brandSelect').select2({
        dropdownParent: $('#ModalCenter'),
        ajax: {
            "url": "../JSON/select.json",
            dataType: 'json'
        }
    });

})


$(document).ready(function () {
    $('.stockSelect').select2({
        dropdownParent: $('#ModalToggle2'),
        ajax: {
            "url": "../JSON/select.json",
            dataType: 'json'
        }
    });

})