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

// Change JumpMenu dot css here 
window.jumpMenuCss = () => {
    let jumpMenuDots = document.getElementsByName('jumpMenuDot');
    if (jumpMenuDots != null && jumpMenuDots != undefined && jumpMenuDots.length > 0) {
        window.addEventListener('scroll', () => {
            for (let i = 0; i < jumpMenuDots.length; i++) {
                //console.log(jumpMenuDots[i].getAttribute('data-section'));
                let section = jumpMenuDots[i].getAttribute('data-section').trim();
                if (section != null && section != undefined) {
                    let targetSection = document.getElementById(section);
                    if (targetSection.getBoundingClientRect().y < 140 &&
                        targetSection.getBoundingClientRect().y + targetSection.getBoundingClientRect().height > 1
                    ) {
                        console.log(section + " scrolled in viewport!");
                        jumpMenuDots[i].style.opacity = "100%";
                    } else {
                        jumpMenuDots[i].style.opacity = "50%";
                    }
                }
            }
            //if (document.getElementById('carouselSection').getBoundingClientRect().y < 1 &&
            //    document.getElementById('carouselSection').getBoundingClientRect().y + document.getElementById('carouselSection').getBoundingClientRect().height > 1
            //) {
            //    console.log("CarouselSection scrolled in viewport!");
            //    document.getElementById('carouselSection').style.opacity = "90%";
            //}
        });
    }
}