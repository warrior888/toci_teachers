/**
 * Created by Michal on 2015-07-26.
 */
function changeArrowOnResize() {

    var arrowRight=$("#arrow-right");
    var arrowLeft=$("#arrow-left");


    if(window.innerWidth<768) {
        arrowRight.attr('src','images/arrow-down.png');
        arrowLeft.attr('src','images/arrow-down.png');

        arrowLeft.css('float','none');
        arrowRight.css('float','none');

        arrowLeft.addClass('center-block');
        arrowRight.addClass('center-block');


    }
    else {
        arrowRight.attr('src','images/arrow-right.png');
        arrowLeft.attr('src','images/arrow-left.png');

        arrowLeft.css('float','left');
        arrowRight.css('float','right');

        arrowLeft.removeClass('center-block');
        arrowRight.removeClass('center-block');

    }
}

function turnLoaderOff(){

    var loaderCSS = {
        "visibility":"hidden",
        "height": "0",
        "margin":"0"
    };

    $("#loader").css(loaderCSS);

    $("#content").css('visibility','visible');
    $(document.body).css('overflow-y','visible');


};

function initMap(){

    // Basic options for a simple Google Map
    // For more options see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
    var mapOptions = {
        // How zoomed in you want the map to start at (always required)
        zoom: 15,

        // The latitude and longitude to center the map (always required)
        center: new google.maps.LatLng(50.6672560, 17.9048559),
        disableDefaultUI: true,

        //jasny szary
        styles: [{"featureType":"landscape","stylers":[{"saturation":-100},{"lightness":45},{"visibility":"on"}]},{"featureType":"poi","stylers":[{"saturation":-100},{"lightness":35},{"visibility":"simplified"}]},{"featureType":"road.highway","stylers":[{"saturation":-100},{"visibility":"simplified"}]},{"featureType":"road.arterial","stylers":[{"saturation":-100},{"lightness":30},{"visibility":"on"}]},{"featureType":"road.local","stylers":[{"saturation":-100},{"lightness":40},{"visibility":"on"}]},{"featureType":"transit","stylers":[{"saturation":-100},{"visibility":"simplified"}]},{"featureType":"administrative.province","stylers":[{"visibility":"off"}]},{"featureType":"water","elementType":"labels","stylers":[{"visibility":"on"},{"lightness":-25},{"saturation":-100}]},{"featureType":"water","elementType":"geometry","stylers":[{"hue":"#ffff00"},{"lightness":-25},{"saturation":-97}]}]
    };

    // Get the HTML DOM element that will contain your map
    // We are using a div with id="map" seen below in the <body>
    var mapElement = document.getElementById('mapa');

    // Create the Google Map using our element and options defined above
    var map = new google.maps.Map(mapElement, mapOptions);

    // Let's also add a marker while we're at it
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(50.6672560, 17.9048559),
        map: map,
        title: 'Toci !'
    });

    google.maps.event.addDomListener(window, "resize", function() {
        var center = map.getCenter();
        google.maps.event.trigger(map, "resize");
        map.setCenter(center);
    });


}