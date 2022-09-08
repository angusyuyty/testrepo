// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.initFlickity = () => {
    console.log("## init Flickity ##");
    //$('.main-carousel').flickity({
    //    // options
    //    cellAlign: 'left',
    //    contain: true,
    //    arrowShape: 'M 0,50 L 60,00 L 50,30 L 80,30 L 80,70 L 50,70 L 60,100 Z',
    //    wrapAround: true
    //});

    //$('.news-carousel').flickity({
    //    // options
    //    cellAlign: 'left',
    //    contain: true,
    //    groupCells: 3,
    //    wrapAround: true
    //});
    var mainCarousel = document.querySelector('.main-carousel');
    var mainCarouselFlkty = new Flickity(mainCarousel, {
        // options
        cellAlign: 'left',
        contain: true,
        arrowShape: 'M 0,50 L 60,00 L 50,30 L 80,30 L 80,70 L 50,70 L 60,100 Z',
        wrapAround: true
    });

    var newsCarousel = document.querySelector('.news-carousel');
    var newsCarouselFlkty = new Flickity(newsCarousel, {
        // options
        cellAlign: 'left',
        contain: true,
        //groupCells: 3,
        wrapAround: true
    });
}