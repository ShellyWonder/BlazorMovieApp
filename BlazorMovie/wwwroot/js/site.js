//accessing sessionStorage

window.sessionStorageHelper = {
    setItem: function (key, value) {
        sessionStorage.setItem(key, JSON.stringify(value));
    },

    getItem: function (key) {
        // Return raw JSON string for debugging purposes
        return sessionStorage.getItem(key);
        console.log(sessionStorage.getItem(key));
    }
};



function showModal(modalId) {
    $('#' + modalId).modal('show');
}

function hideModal(modalId) {
    $('#' + modalId).modal('hide');
}
