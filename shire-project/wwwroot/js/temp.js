function get_temp() {
    $.ajax({
        url: 'dashboard/temp',
        type: 'GET',
        success: function (data) {
            data = JSON.parse(data);
            $("#hlt").text(data["hlt"]);
            $("#mlt").text(data["mlt"]);
            $("#bk").text(data["bk"]);
        },
        error: function (request, status, error) {
            alert('Error: ' + request.responseText);
        }
    });
}
// legacy function to handle state of brew session
//function on_off() {
//    $.ajax({
//        url: '/session',
//        type: 'GET',
//        success: function (data) {
//            $("#on_off").text(data["button"]);
//            if (data["button"] == "") {
//                $("#buttondiv").hide();
//            } else {
//                $("#buttondiv").show();
//            }
//            $("#prompt").text(data["prompt"]);
//            $("#image").attr('src', data["image"]);
//        },
//        error: function (request, status, error) {
//            alert('Error: ' + request.responseText);
//        }
//    });
//}

// legacy function to handle state of brew session
//function toggle() {
//    $.ajax({
//        url: '/session',
//        type: 'POST',
//        success: function (data) {
//            $("#on_off").text(data["button"]);
//            if (data["button"] == "") {
//                $("#buttondiv").hide();
//            } else {
//                $("#buttondiv").show();
//            }
//            $("#prompt").text(data["prompt"]);
//            $("#image").attr('src', data["image"]);
//        },
//        error: function (request, status, error) {
//            alert('Error: ' + request.responseText);
//        }
//    });
//}
//on_off()
get_temp()
setInterval(function () {
    get_temp()
    //on_off()
}, 1000);
setInterval(function () {
    // legacy function that worked with the brew sessions timer
    //$.ajax({
    //url: '/timer',
    //    type: 'GET',
    //    success: function (data) { },
    //    error: function (request, status, error) {
    //alert('Error: ' + request.responseText);
    //    }
    //});
}, 2000);
