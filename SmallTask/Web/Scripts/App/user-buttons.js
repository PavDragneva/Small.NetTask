(function () {
    $(".delete-button").on("click", function () {
        $.ajax({
            type: 'Put',
            url: '/api/apiuser/deleteuser/' + this.id,
            success: function (response) {
                window.location.href = "/User/Index";
            },
            error: function (error) {
                console.log(error);
            }
        });
    });

    $(".activator").on("change", function () {
        $.ajax({
            type: 'Put',
            url: '/api/apiuser/updatestatus/' + $(this).attr("data-id"),
            success: function (response) {
                window.location.href = "/User/Index";
            },
            error: function (error) {
                console.log(error);
            }
        });
    });
}())
