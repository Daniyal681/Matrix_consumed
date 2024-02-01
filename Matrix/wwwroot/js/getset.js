$('#getGlAccount').on('change',function(e){
    var inputGl = document.getElementById("getGlAccount").value;
    $.ajax({
        url: "../JSON/jspreadsheet.json",
        type: "GET",
        success: function (resp) {
            for(var i = 0; i<resp.length; i++){
                if(inputGl == resp[i].Id){
                    $('#setGlAccount').val(resp[i].val);            
                }
            }
        }
    });
})


$('#getGlTransit').on('change',function(e){
    var inputGl = document.getElementById("getGlTransit").value;
    $.ajax({
        url: "../JSON/jspreadsheet.json",
        type: "GET",
        success: function (resp) {
            for(var i = 0; i<resp.length; i++){
                if(inputGl == resp[i].Id){
                    $('#setGlTransit').val(resp[i].val);            
                }
            }
        }
    });
})


$('#getGlReturn').on('change',function(e){
    var inputGl = document.getElementById("getGlReturn").value;
    $.ajax({
        url: "../JSON/jspreadsheet.json",
        type: "GET",
        success: function (resp) {
            for(var i = 0; i<resp.length; i++){
                if(inputGl == resp[i].Id){
                    $('#setGlReturn').val(resp[i].val);            
                }
            }
        }
    });
})


$('#getGlSales').on('change',function(e){
    var inputGl = document.getElementById("getGlSales").value;
    $.ajax({
        url: "../JSON/jspreadsheet.json",
        type: "GET",
        success: function (resp) {
            for(var i = 0; i<resp.length; i++){
                if(inputGl == resp[i].Id){
                    $('#setGlSales').val(resp[i].val);            
                }
            }
        }
    });
})


$('#getGlAdjustment').on('change',function(e){
    var inputGl = document.getElementById("getGlAdjustment").value;
    $.ajax({
        url: "../JSON/jspreadsheet.json",
        type: "GET",
        success: function (resp) {
            for(var i = 0; i<resp.length; i++){
                if(inputGl == resp[i].Id){
                    $('#setGlAdjustment').val(resp[i].val);            
                }
            }
        }
    });
})


