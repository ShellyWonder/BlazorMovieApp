//accessing sessionStorage

    window.sessionStorageHelper = {
        setItem: function (key, value) {
            sessionStorage.setItem(key, JSON.stringify(value));
        },
        getItem: function (key) {
            const item = sessionStorage.getItem(key);
            return sessionStorage.getItem(key);
        }
    }



function showModal(modalId) {
    $('#' + modalId).modal('show');
}

function hideModal(modalId) {
    $('#' + modalId).modal('hide');
}
