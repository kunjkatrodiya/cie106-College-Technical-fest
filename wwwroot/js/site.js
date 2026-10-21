// ============================================
// AMTICS TECHNICAL FEST - DYNAMIC EFFECTS
// ============================================

document.addEventListener("DOMContentLoaded", function () {

    // Create floating particles
    const numberOfParticles = 35;

    for (let i = 0; i < numberOfParticles; i++) {

        const particle = document.createElement("div");

        particle.classList.add("fest-particle");

        particle.style.left =
            Math.random() * 100 + "vw";

        particle.style.animationDuration =
            (6 + Math.random() * 10) + "s";

        particle.style.animationDelay =
            Math.random() * 8 + "s";

        particle.style.width =
            (3 + Math.random() * 5) + "px";

        particle.style.height =
            particle.style.width;

        document.body.appendChild(particle);
    }

});