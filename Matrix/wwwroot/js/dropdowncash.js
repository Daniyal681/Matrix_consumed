
$(document).ready(function () {
    // Initial list of brands
    const brands = [
        'Internal Transfer', 'Cheque Returned From', 'Payment', 'Bank Deposit', 'Expenses',
        'Cheque Returned To', 'Seven', 'Eight', 'Nine', 'Ten'
    ];

    // Function to generate checkboxes based on the search query
    function generateCheckboxes(query) {
        const container = $('#forfollowingcheckbox');
        container.empty(); // Clear previous checkboxes

        for (const brand of brands) {
            // Check if the brand matches the search query
            if (brand.toLowerCase().includes(query.toLowerCase())) {
                const checkbox = $('<div class="form-check ml-1">');
                const input = $('<input class="form-check-input" type="checkbox">');
                const label = $(`<label class="form-check-label">${brand}</label>`);
        
                // Connect the label to the checkbox
                label.attr('for', `checkbox-${brand}`);
                input.attr('id', `checkbox-${brand}`);
        
                checkbox.append(input);
                checkbox.append(label);
                container.append(checkbox);
            }
        }
    }

    // Initial generation of checkboxes
    generateCheckboxes('');

    // Event listener for search input
    $('#searchInput').on('input', function () {
        const searchQuery = $(this).val();
        generateCheckboxes(searchQuery);
    });
});





// Payment Modes


$(document).ready(function () {
    // Initial list of brands
    const brands = [
        'Cash - Hafeez Center', 'Cash - Shop Islamabad', 'Cash - Karachi', 'Cash - Packages Mall', 'Cash - Sahiwal',
        'Cash - Unnited Center', 'Seven', 'Eight', 'Nine', 'Ten'
    ];

    // Function to generate checkboxes based on the search query
    function generateCheckboxes(query) {
        const container = $('#paymentmodescheckbox');
        container.empty(); // Clear previous checkboxes

        for (const brand of brands) {
            // Check if the brand matches the search query
            if (brand.toLowerCase().includes(query.toLowerCase())) {
                const checkbox = $('<div class="form-check ml-1">');
                const input = $('<input class="form-check-input" type="checkbox">');
                const label = $(`<label class="form-check-label">${brand}</label>`);
        
                // Connect the label to the checkbox
                label.attr('for', `checkbox-${brand}`);
                input.attr('id', `checkbox-${brand}`);
        
                checkbox.append(input);
                checkbox.append(label);
                container.append(checkbox);
            }
        }
    }

    // Initial generation of checkboxes
    generateCheckboxes('');

    // Event listener for search input
    $('#cashsearch').on('input', function () {
        const searchQuery = $(this).val();
        generateCheckboxes(searchQuery);
    });
});






// Operating Units


$(document).ready(function () {
    // Initial list of brands
    const brands = [
        'One', 'Two', 'Three', 'Four','Five','Six','Seven','Eight',
    ];
    // Function to generate checkboxes based on the search query
    function generateCheckboxes(query) {
        const container = $('#operatingcheckbox');
        container.empty(); // Clear previous checkboxes

        for (const brand of brands) {
            // Check if the brand matches the search query
            if (brand.toLowerCase().includes(query.toLowerCase())) {
                const checkbox = $('<div class="form-check ml-1">');
                const input = $('<input class="form-check-input" type="checkbox">');
                const label = $(`<label class="form-check-label">${brand}</label>`);
        
                // Connect the label to the checkbox
                label.attr('for', `checkbox-${brand}`);
                input.attr('id', `checkbox-${brand}`);
        
                checkbox.append(input);
                checkbox.append(label);
                container.append(checkbox);
            }
        }
    }

    // Initial generation of checkboxes
    generateCheckboxes('');

    // Event listener for search input
    $('#operatingsearch').on('input', function () {
        const searchQuery = $(this).val();
        generateCheckboxes(searchQuery);
    });
});




