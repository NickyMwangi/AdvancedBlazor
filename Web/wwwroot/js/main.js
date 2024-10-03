﻿window.showToastr =  (type, message) =>  {
    console.log(type)
    switch (type) {
        case "success":
            toastr.success(message);
            break;
        case "error":
            toastr.error(message);
            break;
        case "warning":
            toastr.warning(message);
            break;
        case "info":
            toastr.info(message);
            break;
        default:
            toastr.success("I have been loaded by default.");
            break;
    }
}