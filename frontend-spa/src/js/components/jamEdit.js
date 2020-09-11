export default function JamEdit(jam) {
    return `
    <section class="info-details">
    <h2>Title: <input class="edit-jam__name" type="text" value="${jam.name}"></h2>  
    <h4><a class="jamdetails__name" id="${jam.jamId}" href="#"> <img src="images/jamphoto.png" alt="${jam.image}" width="200" height="200"></a></h4>
    <h4>Where: <input class="edit-jam__location" type="text" value="${jam.location}"></h4>
    <h4>Description: <input class="edit-jam__description" type="text" size="70" value="${jam.description}"></h4>
    <h4>When: <input class="edit-jam__date" type="datetime-local" value="${jam.eventDate}"></h4>
    <label for="edit-jam__attendees">Max Number of Attendees: </label>
    <select class="edit-jam__attendees" style="width: 50px;">
    <option value="1">1</option>
    <option value="2">2</option>
    <option value="3">3</option>
    <option value="4">4</option>
    </select>
    </section>
    <button class="edit-jam__submit" id="${jam.jamId}" value="${jam.jamId}">Update Jam</button>

<h3>Attendees</h3>
${jam.jamsAttending.map(jamAttendee => {
    return `
    <h4>${jamAttendee.profile.name}</h4> 
    <h4>${jamAttendee.profile.instruments}</h4> 

    <button class="jam__leaveJam_button" id="${jamAttendee.profileId}">Leave Jam</button>
 
    `
}).join("")} 

`
}