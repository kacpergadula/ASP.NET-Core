(function () {

    const alertElement = document.getElementById("success-alert");
    const button = document.getElementById("button");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        const name = document.getElementById("name").value;
        const description = document.getElementById("description").value;
        const isVisible = document.getElementById("isvisible").checked;

        const data = { Name: name, Description: description, IsVisible: isVisible };

        const requestData = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        };

        const response = await fetch('/api/Ajax', requestData);

        const responseJson = await response.json();
        if (responseJson.success) {
            alertElement.style.display = 'block';
        }
    };
    button.addEventListener("click", () => {
        event.preventDefault();
        addNewItem().then(() => console.log("added successfully"));
    });
})();