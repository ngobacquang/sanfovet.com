function slideSwitch() {
    var $active = $('#slideshow img.active');
    var $next = $active.next();

    $next.addClass('active');

    $active.removeClass('active');
}

$(function () {
    setInterval("slideSwitch()", 5000);
});
function slideSwitch() {
    var $active = $('#slideshow IMG.active');
    var $next = $active.next();

    $active.addClass('last-active');

    $next.css({ opacity: 0.0 })
        .addClass('active')
        .animate({ opacity: 1.0 }, 1000, function () {
            $active.removeClass('active last-active');
        });
}