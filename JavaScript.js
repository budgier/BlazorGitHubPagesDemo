window.websocketFunctions = {
    createWebSocket: function (url) {
        window.websocket = new WebSocket(url);
    },
    send: function (message) {
        window.websocket.send(message);
    },
    receive: function (dotnetHelper) {
        window.websocket.onclose = function (event) {
            dotnetHelper.invokeMethodAsync('ReceiveMessage', event.data);
        }
        window.websocket.onmessage = function (event) {
            dotnetHelper.invokeMethodAsync('ReceiveMessage', event.data);
        };
    }
};

