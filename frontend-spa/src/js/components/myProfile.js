export default function MyProfile(profile) {
    return `
    <li class="workoutdetails-collection"/li>
    <h2>${profile.name}</h2>  
    <li><a class="profiledetails__name" id="${profile.profileId}" href="#"> <img src="images/${profile.image}" alt="${profile.image}" width="200" height="200"> ${profile.name}</a></li>
    <li>${profile.location}</li>
    <li>${profile.instruments}</li>
    <li>${profile.description}</li>
    <button class="profile__delete_button" id="${profile.profileId}" value="${profile.profileId}">Delete Profile</button>                   
    <button class="profile__edit_button" id="${profile.profileId}" value="${profile.profileId}">Edit Profile</button>                   
    
    `
}