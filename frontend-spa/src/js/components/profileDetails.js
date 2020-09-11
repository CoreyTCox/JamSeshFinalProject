export default function ProfileDetails(profile) {
    return `
    <section class="info-details">
    <div class="info-collection"/div>
    <h2>Username: ${profile.name}</h2>  
    <h4><a class="profiledetails__name" id="${profile.profileId}" href="#"> <img src="images/${profile.image}" alt="${profile.name}" width="200" height="200"></a></h4>
    <h4>From: ${profile.location}</h4>
    <h4>Instruments: ${profile.instruments}</h4>
    <div><h4>Bio: </h4>${profile.description}</div>
    </section>
    <div class="delete-profile">
    <img class="delete-profile__button" src="images/deleteIcon.png" alt="Delete this Profile" width="40px" height="40px">                   
    </div>
    <div class="edit-profile">
    <img class="profile-edit__button" src="images/editIcon.png" alt="Edit this Profile" width="40px" height="40px">                   
    </div>
    `
}       