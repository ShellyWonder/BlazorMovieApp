//accessing sessionStorage

    window.sessionStorageHelper = {
        setItem: function (key, value) {
            sessionStorage.setItem(key, JSON.stringify(value));
        },
        getItem: function (key) {
            const item = sessionStorage.getItem(key);
            return item ? JSON.parse(item) : null;
        }
    }



function showModal(modalId) {
    $('#' + modalId).modal('show');
}

function hideModal(modalId) {
    $('#' + modalId).modal('hide');
}
