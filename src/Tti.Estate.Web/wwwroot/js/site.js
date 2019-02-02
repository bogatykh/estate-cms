$(function () {
    $(document).on('click', 'button[data-confirm]', function () {
        var that$ = $(this);
        bootbox.confirm(that$.data('confirm'), function (result) {
            if (result) {
                that$.removeAttr('data-confirm');
                that$.click();
            }
        });
        return false;
    });
});