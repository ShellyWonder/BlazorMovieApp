window.sessionStorageHelper = {
    setItem: function (key, value) {
        sessionStorage.setItem(key, JSON.stringify(value));
    },
    getItem: function (key) {
        const value = sessionStorage.getItem(key);
        return value ? value : null;
    }
};

 
