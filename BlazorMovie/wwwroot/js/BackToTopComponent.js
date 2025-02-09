window.scrollHelper = {
    checkButtonExists: function () {
        return !!document.getElementById("backToTop"); // Returns true if button exists
    },

    ensureButtonExists: function () {
        let checkExist = setInterval(function () {
            let backToTopBtn = document.getElementById("backToTop");
            if (backToTopBtn) {
                clearInterval(checkExist); // Stop checking once found
            }
        }, 100); // Check every 100ms
    },

    initBackToTop: function () {
        let backToTopBtn = document.getElementById("backToTop");

        if (!backToTopBtn) {
            console.error("BackToTop button not found.");
            return;
        }

        window.addEventListener("scroll", function () {
            if (document.documentElement.scrollTop > 500) { // Threshold set to 500px
                backToTopBtn.classList.add("show");
            } else {
                backToTopBtn.classList.remove("show");
            }
        });
    }
};
