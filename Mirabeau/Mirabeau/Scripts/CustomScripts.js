$(function () {
    //For compare page
    if (window.location.pathname.toLowerCase().indexOf("compare") == -1) {
        //Country list DD change
        $("#countrylist").change(function () {
            window.location.href = "/" + "?ccode=" + $(this).val()
        });
        //Page number DD change
        $("#PaginationNumber").change(function () {
            window.location.href = "/" + "?ccode=" + $("#countrylist").val() + "&pno=" + $(this).val()
        });
    }
    else {
        var last_valid_selection = null;
        // Compare list change event
        $('#compare-airport').change(function (event) {
            $("#compare-button").attr("disabled", "");
            if ($(this).val().length == 2) {
                $("#compare-button").removeAttr("disabled");
            }
            else
                if ($(this).val().length > 2) {

                    $(this).val(last_valid_selection);
                } else {
                    last_valid_selection = $(this).val();
                }
        });
        // Compare button click event
        $("#compare-button").click(function () {

            var selMulti = $.map($("#compare-airport option:selected"), function (el, i) {
                return $(el).text();
            });

            window.location.href = "/compare" + "?iata=" + selMulti.join(",");
        });
    }

});