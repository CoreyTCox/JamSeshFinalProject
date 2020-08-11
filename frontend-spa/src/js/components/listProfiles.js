export default function listProfiles(profiles){
    return `
            
        <ul class="info-collection">
            ${profiles.map(profile => {
                return `
                
                <section class="info-details">
                    <li><h3 class="profiles__name" id="${profile.profileId}">Username: ${profile.name}</h3>
                    <li><h3>From: ${profile.location}</h3>
                    <li><h3>Instruments: ${profile.instruments}</h3>
                    <li><h3>Bio: ${profile.description}</h3>
                    <button class="profile-details__button" id="${profile.profileId}">Profile Details</button>
                </a>
            </li>
        </section>
       
    `
}).join("")}           
</ul>
<section class="add-profile">
        <button class="add-profile__button">Create Profile </button>
        <img class="add-profile__button" src="images/profilephoto.png" alt="Create a Profile" width="40px" height="40px"></img>

        </section>
`
}