function createAlert() {
    alert("Alert from JS");
}

function createPrompt(question) {
    return prompt(question);
}

function setElementTextById(id, text) {
    document.getElementById(id).innerText = text;
}

function focusJS(element) {
    element.focus();
}

function GenerateRN(maxIntSize) {
    DotNet.invokeMethodAsync('Brello', 'GenerateRandomInt', maxIntSize)
        .then(result => {
            setElementTextById('RandomNumber', result);
        });
}