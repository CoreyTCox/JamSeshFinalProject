export default function ProfileDetails(profile) {
    return `
    <section class="info-details">
    <div class="info-collection"/div>
    <h2>Username: ${profile.name}</h2>  
    <h4><a class="profiledetails__name" id="${profile.profileId}" href="#"> <img src="images/profilephoto.png" alt="${profile.name}" width="200" height="200"></a></h4>
    <h4>From: ${profile.location}</h4>
    <h4>Instruments: ${profile.instruments}</h4>
    <div><h4>Bio: </h4>${profile.description}</div>
    <button class="delete-profile__button" id="${profile.profileId}" value="${profile.profileId}">Delete Profile</button>                   
    <button class="profile-edit__button" id="${profile.profileId}" value="${profile.profileId}">Edit Profile</button>                   

    
    `
}       