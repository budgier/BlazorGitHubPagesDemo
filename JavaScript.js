window.websocketFunctions = {
    createWebSocket: function (url) {
        window.websocket = new WebSocket(url);
        window.xhr = xhr = new XMLHttpRequest();
    },

  
    send: function (message) {
        window.websocket.send(message);
    },

    xhr: function (match) {
        
        window.xhr.open("GET", match, true);
        window.xhr.send();
          
        }
    
    ,

    xhrPOST: function () {
        window.xhr.open("POST", "https://www.tipsport.sk/rest/offer/v1/live/event-groups/matches", true);
        window.xhr.setRequestHeader('Content-Type', 'application/json'); // Set the request header for JSON

        var data = JSON.stringify({ "section": "IN_PLAY", "filter": { "tracker": false, "audioStream": false, "videoStream": false, "tipbankContest": false, "voiceChannel": false }, "order": "COMPETITION_SPORT" });
        window.xhr.send(data);
},


    receivePOST: function (dotnetHelper) {
        window.xhr.onload = () => {
            dotnetHelper.invokeMethodAsync('ReceiveMessageXhr', window.xhr.response);
        }
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

window.openAndCloseWindow = function (site) {
    var newWindow = window.open(site, "_blank");
    setTimeout(function () {
        newWindow.close();
    }, 3000); // Change this value to set the timeout duration
}
