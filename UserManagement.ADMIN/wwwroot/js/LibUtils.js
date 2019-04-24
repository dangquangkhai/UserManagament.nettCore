﻿class LibUtils {
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
    } else {
      axios.get(url).then(responese => {
        data = responese;
      });
    }
    return data;
  }

  static cloneObject(obj) {
    var clone = {};
    for (var key in obj) {
      if (obj.hasOwnProperty(key))
        //ensure not adding inherited props
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

  static convertDate(inputFormat) {
    function pad(s) {
      return s < 10 ? "0" + s : s;
    }
    var d = new Date(inputFormat);
    return [pad(d.getDate()), pad(d.getMonth() + 1), d.getFullYear()].join("/");
  }

  static formatDayHour(date) {
    if (date !== undefined && date !== null && date !== "") {
      return moment(date).format("DD/MM/YYYY HH:mm");
    } else {
      return "Chưa đặt dữ liệu";
    }
  }
  static callToast(
    title,
    messange,
    flag = "success",
    time = 5000,
    autoClose = true,
    limitShowToast = 5,
    transition = "slide",
    location = "bottom-left",
    backgroundcolor = undefined,
    textcolor = undefined
  ) {
    if (flag === "No-Icon") {
      return $.toast({
        heading: title,
        text: messange,
        showHideTransition: transition,
        allowToastClose: autoClose,
        hideAfter: time,
        position: location,
        stack: limitShowToast
      });
    } else {
      return $.toast({
        heading: title,
        text: messange,
        showHideTransition: transition,
        allowToastClose: autoClose,
        hideAfter: time,
        icon: flag,
        position: location,
        stack: limitShowToast
      });
    }
  }

  static isEmail(str)
  {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
  }
  static isValidDate(d) {
    return d instanceof Date && !isNaN(d);
  }
}
