// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Displayed calculation field for group cost
$("#btnGroupCost").click(function () {

    $("#pricingDiv").css('display', 'block');

    const groupCost = 25;

    $("#chargeHourly").val(groupCost);

    var targetPosition = 700;

    //scrolls to calculation field
    setTimeout(function ()
    {
        $('html, body').animate({
            scrollTop: targetPosition
        }, 3000); // Adjust the duration as needed
    }, 500); // Adjust the wait time as needed
});

//Displayed calculation field for private cost
$("#btnPrivateCost").click(function () {

    $("#pricingDiv").css('display', 'block');

    const privateCost = 60;

    $("#chargeHourly").val(privateCost);

    var targetPosition = 700; 

    //scrolls to calculation field
    setTimeout(function () {
        $('html, body').animate({
            scrollTop: targetPosition
        }, 3000); // Adjust the duration as needed
    }, 500); // Adjust the wait time as needed
});

//Calculator button that validates if there is a positive number
$("#btnSubmit").click(function () {

    let lessonHours = parseInt($('#lessonHours').val());


    //checks if positive number then adds value to input box
    if (Number.isInteger(lessonHours) == true && lessonHours > 0) {
        let totalCost = ($("#lessonHours").val() * $("#chargeHourly").val());

        $('#lessonHours').removeClass('is-invalid');
        $('#lessonHours').addClass('is-valid');

        $("#totalCost").val("$" + totalCost);

    }
    else if (Number.isInteger(lessonHours) == true && lessonHours < 0) {
        $('#lessonHours').removeClass('is-valid');
        $('#lessonHours').addClass('is-invalid');
        alert("Please enter a positive number.");
    }
    else {
        $('#lessonHours').removeClass('is-valid');
        $('#lessonHours').addClass('is-invalid');
        alert("Not a number. Please enter a positive number for hours.");
    }
});

$("#btnAbout").click(function () {

    var targetPosition = 1800; 

    //scrolls to about section
    $('html, body').animate({
        scrollTop: targetPosition
    }, 500); // Adjust the duration as needed
});

