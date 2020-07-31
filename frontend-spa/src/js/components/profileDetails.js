export default function ProfileDetails(profile) {
    return `
    <li class="workoutdetails-collection"/li>
    <h2>${profile.name}</h2>  
    <li><a class="profiledetails__name" id="${profile.id}" href="#"> <img src="images/${profile.image}" alt="${profile.image}" width="200" height="200"> ${profile.name}</a></li>
    <li>${profile.location}</li>
    <li>${profile.instruments}</li>
    <li>${profile.description}</li>
    <button class="delete-profile__button" id="${profile.id}" value="${profile.id}">Delete Profile</button>                   
    <button class="profile__edit_button" id="${profile.id}" value="${profile.id}">Edit Profile</button>                   

    
    `
}