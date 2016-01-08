
window.applicationInterface = {
    addMessage: function(text) {
        var container = document.getElementById('interface-area'),
            messageNode = document.createElement('p');

        messageNode.appendChild(document.createTextNode(text));

        container.appendChild(messageNode);
    }
};
