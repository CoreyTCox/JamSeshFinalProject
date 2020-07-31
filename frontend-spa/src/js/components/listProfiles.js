export default function listProfiles(profiles){
    return `
            
        <ul class="workout-collection">
            ${profiles.map(profile => {
                return `
                
                <section class="workout-style">
                    <li><h3 class="profiles__name" id="${profile.id}">name: ${profile.name}</h3>
                    <li><h3>location: ${profile.location}</h3>
                    <li><h3>instruments: ${profile.instruments}</h3>
                    <li><h3>description: ${profile.description}</h3>
                    <button class= "profile-details__button" Id="${profile.id}">Profile Details</button>
                    <img class="profile__name" src="images/${profile.image}" alt="${profile.image}" width="200" height="200"></img>
                </a>
            </li>
        </section>
       
    `
}).join("")}           
</ul>
<section class="add-profile">
        <button class="add-profile__button">Create Profile </button>
        </section>
`
}