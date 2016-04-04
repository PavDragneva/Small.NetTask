
(function() {
    $(".delete-button").on("click", function (clicked_id) {
        $.ajax({
            type: 'Delete',
            url: '/api/apiuser/' + clicked_id
        });
    });

    $(".activator").on("change", function () {
        $.ajax({
            type: 'Put',
            url: '/api/apiuser/' + $(this).val()
        });
    });
}())