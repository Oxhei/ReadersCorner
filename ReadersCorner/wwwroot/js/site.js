let count = 1;
document.getElementById('radio1').checked = true;

setInterval(funtion(){
    nextimage();

}, 3000)

function nextImage() {
    count++;
    if (count > 4) {
        count = 1;
    }
    document.getElementById('radio+count').checked = true;
}

<script>
    document.addEventListener('DOMContentLoaded', function () {
        // Initialize the carousel
        var myCarousel = new bootstrap.Carousel(document.getElementById('imageCarousel'));
    });
</script>
