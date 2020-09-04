const tilesProvider = 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png'

let myMap = L.map('myMap').setView([-1.676427, -78.655091], 15)

L.tileLayer(tilesProvider, {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(myMap);
myMap.doubleClickZoom.disable()
myMap.on('dblclick', e => {
    let latLng = myMap.mouseEventToLatLng(e.originalEvent)
    L.marker([latLng.lat, latLng.lng]).addTo(myMap)
    $('#txtlat').val(latLng.lat.toFixed(6));
    $('#txtlong').val(latLng.lng.toFixed(6));
})

//var popup = L.popup();

//function onMapClick(e) {
//    popup
//        .setLatLng(e.latlng)
//        .setContent("You clicked the map at " + e.latlng.toString())
//        .openOn(mymap);
//}

//mymap.on('click', onMapClick);