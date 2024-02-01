
var data2 = [
    [],
    [],
    [],
    [],
    [],
    [],
];

var myTable;

var data = [
    { type: 'numeric', title: 'Serial Number', width: 110, mask:'000' },
    { type: 'numeric', title: 'IMEI Number', width: 140 },
    { type: 'numeric', title: 'MSN Number', width: 100, mask:'' },
    { type: 'date', title: 'Start Date', width: 100, mask:''},
    { type: 'date', title: 'End Date', width: 100, mask:''},
    { type: 'text', title: 'Serial Key', width: 150 }
];

var customColumn = {
    // Methods
    closeEditor: function (cell, save) {
        var value = cell.children[0].value;
        cell.innerHTML = value;

        if (cell.cellIndex === 0) {
            // Get the next cell in the same row (assuming it exists)
            var nextCell = cell.nextElementSibling;
            if (nextCell) {
                // Update the value in the second column
                updateModelDescription(nextCell);
            }
        }

        return value;
    },
    openEditor: function (cell) {
        // Create input
        var element = document.createElement('input');
        element.value = cell.innerHTML;
        // Update cell
        cell.classList.add('editor');
        cell.innerHTML = '';
        cell.appendChild(element);
        $(element).clockpicker({
            afterHide: function () {
                setTimeout(function () {
                    // To avoid double call
                    if (cell.children[0]) {
                        myTable.closeEditor(cell, true);
                    }
                });
            }
        });
        // Focus on the element
        element.focus();
    },
    getValue: function (cell) {
        return cell.innerHTML;
    },
    setValue: function (cell, value) {
        cell.innerHTML = value;
    },
}

myTable = jspreadsheet(document.getElementById('spreadsheet'), {
    data: data2,
    columns: data,
    allowInsertColumn: false,
    onchange: function(event,obj,index,row,changedValue,e,f){
        if(index == "0")
            GetModelName(row,changedValue);
        if(index == "5")
            GetWarehouseName(row,changedValue);
    },
    
});


function GetModelName(row,val) {

    $.ajax({
        url: "../JSON/jspreadsheet.json",
        type: "GET",
        data: {"modelID": val},
        success: function (resp) {
            
            if(resp!=null && resp.material){
                data2[row][1] = resp.material;
                myTable.refresh();
            }
            
        }
    });
}
function GetWarehouseName(row,val) {

    $.ajax({
        url: "../JSON/jspreadsheet.json",
        type: "GET",
        data: {"modelID": val},
        success: function (resp) {
            
            if(resp!=null && resp.material){
                data2[row][6] = resp.material;
                myTable.refresh();
            }
            
        }
    });
}









