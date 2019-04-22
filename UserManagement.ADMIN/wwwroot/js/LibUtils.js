class LibUtils {
    static formatDate(date) {
        if (date !== undefined && date !== null && date !== "") {
            return moment(date).format("DD/MM/YYYY");
        } else {
            return "Chưa đặt dữ liệu";
        }
    }

    static isEmpty(text) {
        if (text !== null && text !== undefined && text !== "") {
            return false;
        }
        return true;
    }

    static getData(url) {
        var data = undefined;
        if (LibUtils.isEmpty(url)) {
            data = false;
        }
        else {
            axios
                .get(url)
                .then(responese => {
                    data = responese;
                });
        }
        return data;
    }

    static cloneObject(obj) {
        var clone = {};
        for (var key in obj) {
            if (obj.hasOwnProperty(key)) //ensure not adding inherited props
                clone[key] = obj[key];
        }
        return clone;
    }

    static clearObject(obj) {
        for (var key in obj) {
            obj[key] = null;
        }
    }

    static clearArrObject(obj) {
        for (var item = 0; item < obj.length; i++) {
            this.clearObject(item);
        }
    }

    static convertToJsDate(obj) {
        var date = obj.split("/");
        var output = new Date(+date[2], date[1] - 1, +date[0]);
        return output;
    }

    static  convertDate(inputFormat) {
    function pad(s) { return (s < 10) ? '0' + s : s; }
    var d = new Date(inputFormat);
    return [pad(d.getDate()), pad(d.getMonth() + 1), d.getFullYear()].join('/');
    }

    static formatDayHour(date) {
        if (date !== undefined && date !== null && date !== "") {
            return moment(date).format("DD/MM/YYYY HH:mm");
        } else {
            return "Chưa đặt dữ liệu";
        }
    }

}