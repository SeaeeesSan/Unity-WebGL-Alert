mergeInto(LibraryManager.library, {
    Alert: function (message) {
        window.alert(Pointer_stringify(message));
    },
    Confirm: function (message) {
        var result = window.confirm(Pointer_stringify(message));
        return result;
    },
    Prompt: function (message) {
        var result = window.prompt(Pointer_stringify(message));
        var bufferSize = lengthBytesUTF8(result) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(result, buffer, bufferSize);
        return buffer;
    }
});