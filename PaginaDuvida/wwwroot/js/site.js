jQuery(document).ready(function () {
    $('.expandir-contrair').click(function () {

        var el = $(this).parents('h4').next();

        if (el.hasClass('contraido')) {

            el.slideDown(200);
            el.removeClass('contraido').addClass('expandido');
            $(this).css('-webkit-transform', 'rotate(180deg)');
            $(this).css('-ms-transform', 'rotate(180deg)');
            $(this).css('transform', 'rotate(180deg)');
        } else {

            el.slideUp(200);
            el.removeClass('expandido').addClass('contraido');
            $(this).css('-webkit-transform', 'rotate(360deg)');
            $(this).css('-ms-transform', 'rotate(360deg)');
            $(this).css('transform', 'rotate(360deg)');
        }
    });
});