$(document).ready(function () {
    
    $('body').on('click', 'li.nav-01 > span', function () {
        var $wrap = $('.nav-wrap'),
        $btn = $wrap.find('li.nav-01 > span'),
        $content = $wrap.find('ul.nav-collapse');

        var $el = $(this),
        $elContent = $el.next('ul.nav-collapse');

        if (!$el.hasClass('active')) {
            $content.slideUp();
            $btn.removeClass('active');
            $el.addClass('active');
            $elContent.slideDown();
        } else {
            $el.removeClass('active');
            $elContent.slideUp();
        }
    });
    
    $('body').on('click', 'li.nav-02 > a', function () {
        var $wrap = $('.nav-collapse'),
        $btn = $wrap.find('li.nav-02 > a'),
        $content = $wrap.find('ul.nav-collapse-sub');

        var $el = $(this),
        $elContent = $el.next('ul.nav-collapse-sub');

        if (!$el.hasClass('activeSub')) {
            $content.slideUp();
            $btn.removeClass('activeSub');
            $el.addClass('activeSub');
            $elContent.slideDown();
        } else {
            $el.removeClass('activeSub');
            $elContent.slideUp();
        }
    });
});

/*--------------------------------------------------------------------------------------------------------- 
RESPONSIVE PANEL TABLET
**//*---------------------------------------------------------------------------------------------------- */

var tablet = function () {
    $(document).ready(function () {
        if ($(window).width() < 769) {
            $('[data-toggle=offcanvas]').on('click', function () {
                $('.content-colum').toggleClass('active')
            });
        }
        else { }
    });

    $(window).resize(function () {
        if ($(window).width() < 769) {
            $('[data-toggle=offcanvas]').off('click');
            $('[data-toggle=offcanvas]').on('click', function () {
                $('.content-colum').toggleClass('active')
            });
        }
        else { $('.content-colum').removeClass('active'); }
    });
};

tablet();

var generales = function () {
    $('ul.list-actividad').find('li:nth-child(even)').addClass('interlineado');
    $('table.table').find('tbody tr:nth-child(odd)').addClass('alternative-item');
};



/*--------------------------------------------------------------------------------------------------------- 
CLICK REMOVE ASIDE PANEL
**//*---------------------------------------------------------------------------------------------------- */

var MenuPanel = function () {
    $('body').on('click', '.btn-show', function () {
        var menu = $('#menuHor');
        if (!menu.hasClass('active')) {
            $('.menu').animate({
                left: '-282'
            });
            menu.addClass('active');
        } else {
            $('.menu').animate({
                left: '-282'
            });
            menu.removeClass('active');
        }
    });
}

MenuPanel();


//var navSub = function () {

//    var $wrap = $('.nav-collapse'),
//    $btn = $wrap.find('li.nav-02 > a'),
//    $content = $wrap.find('ul.nav-collapse-sub');

//    $('li.nav-02 > a').on('click', function () {
//        var $el = $(this),
//            $elContent = $el.next('ul.nav-collapse-sub');

//        if (!$el.hasClass('activeSub')) {
//            $content.slideUp();
//            $btn.removeClass('activeSub');
//            $el.addClass('activeSub');
//            $elContent.slideDown();
//        } else {
//            $el.removeClass('activeSub');
//            $elContent.slideUp();
//        }
//    });
//}

//navSub();

var removeMenuPanel = function () {
    $('ul.nav-collapse').find('li.nav-02 > a.nav_ajx').click(function () {
        $("a.btn-show").trigger("click");
    });

    $('ul.nav-collapse-sub').find('li.nav-03 > a.nav_ajx').click(function () {
        $("a.btn-show").trigger("click");
    });
}



/*--------------------------------------------------------------------------------------------------------- 
RESIZE WINDOW SCROLL
**//*---------------------------------------------------------------------------------------------------- */

$(function (bodyResize) {
    $(window).resize(function () {
        $('.main-content').css("height", $(window).innerHeight() - 52);
    });
    $(window).trigger('resize');
});


