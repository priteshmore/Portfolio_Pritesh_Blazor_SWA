let animation;
let progress = 0;
let loadingInterval;

window.onload = function () {
    showLottieLoader();
};

function showLottieLoader() {
    // Initialize Lottie animation
    animation = lottie.loadAnimation({
        container: document.getElementById('loading-screen'),
        renderer: 'svg',
        loop: true, // Keep the animation looping until loader is hidden
        autoplay: true,
        path: 'loading-animation.json' // Path to your Lottie JSON file
    });

    updateLoadingProgress();

}


function updateLoadingProgress() {
    const progressText = document.getElementById('loading-progress-text');

    // Update progress until 90%
    loadingInterval = setInterval(() => {
        if (progress < 100) {
            progress++;
            progressText.textContent = `${progress}%`; // Update the progress percentage
        }
    }, 50);
}

function hideLottieLoader() {
    const overlay = document.getElementById('loading-overlay');
    overlay.style.transition = 'opacity 0.5s';
    overlay.style.opacity = '0';

    // Immediately stop the Lottie animation and hide the loader
    setTimeout(() => {
        overlay.style.display = 'none'; // Hide the loader
        animation.stop(); // Stop Lottie animation
    }, 500); // Match the transition duration
}
