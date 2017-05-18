$('.home').click(function() {
    $('body').animate({scrollTop: eval($('.' + $(this).attr('target1')).offset().top-70)}, 2000);
});

$('.aboutnav').click(function() {
    $('body').animate({scrollTop: eval($('.' + $(this).attr('target2')).offset().top-70)}, 1000);
});

$('.services').click(function() {
    $('body').animate({scrollTop: eval($('.' + $(this).attr('target3')).offset().top-70)}, 1000);
});

$('.statsnav').click(function() {
    $('body').animate({scrollTop: eval($('.' + $(this).attr('target4')).offset().top-70)}, 1000);
});

$('.teamnav').click(function() {
    $('body').animate({scrollTop: eval($('.' + $(this).attr('target5')).offset().top-500)}, 1000);
});

$('.contactnav').click(function() {
    $('body').animate({scrollTop: eval($('.' + $(this).attr('target6')).offset().top-70)}, 2000);
});