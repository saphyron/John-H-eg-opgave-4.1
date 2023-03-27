let listView = document.getElementById("list-view");
let roadSearchForm = document.getElementById("road-search");
let roadCodeForm = document.getElementById("road-code");

function init() {
    if (roadSearchForm !== null) {
        roadSearchForm.addEventListener("submit", (e) => {
            handleSubmitRoadSearch(e);
        });
    }
    if (roadCodeForm !== null) {
        roadCodeForm.addEventListener("submit", (e) => {
            handleSubmitRoadCode(e);
        });
    }
}

async function handleSubmitRoadSearch(event) {
    event.preventDefault();
    const targetInput = document.querySelector('.roadSearch');
    const url = "https://localhost:7005/api/RoadNames?value=" + targetInput.value;
    await fetchRoadSearch(url);
}  

function fetchRoadSearch(url) {
    fetch(url, {
        method: "GET"
    })
        .then(response => response.json())
        .then(data => {
            buildListView(data);
        })
        .catch(error => {
            throw new Error(error);
        })

}

function buildListView(data) {
    clearListView();
    for (var item in data) {
        let p = document.createElement("p");
        p.innerHTML = data[item];
        listView.appendChild(p);
    }

}

function clearListView() {
    while (listView.firstChild) {
        listView.removeChild(listView.lastChild);
    }
}

async function handleSubmitRoadCode(event) {
    event.preventDefault();
    const targetInput = document.querySelector('.roadCode');
    const targetInput2 = document.querySelector('.kommuneCode')
    const url = "https://localhost:7005/api/FindLocation"
        + "?road=" + targetInput.value + "&kommune=" + targetInput2.value;
    await fetchRoadSearch(url);

}

function fetchRoadCode(url) {
    fetch(url, {
        method: "GET"
    })
        .then(response => response.json())
        .then(data => {
            buildListView(data);
        })
        .catch(error => {
            throw new Error(error);
        })

}

init();