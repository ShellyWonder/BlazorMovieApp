window.sessionStorageHelper = {
    setItem: function (key, value) {
        sessionStorage.setItem(key, JSON.stringify(value));
    },
    getItem: function (key) {
        const value = sessionStorage.getItem(key);
        return value ? value : null;
    }
};

function showModal(modalId) {
    $('#' + modalId).modal('show');
}

function hideModal(modalId) {
    $('#' + modalId).modal('hide');
}
