export default function ProfileEdit(profile) {
    return `
    <section class="info-details">
    <h2>Username: <input class="edit-profile__name" type="text" value="${profile.name}"></h2>
    <h4><a class="profiledetails__name" id="${profile.profileId}" href="#"> <img src="images/${profile.image}" alt="${profile.name}" width="200" height="200"></a></h4>
    <h4>From: <input class="edit-profile__location" type="text" value="${profile.location}"></h4>
    <h4>Instruments: <input class="edit-profile__instruments" type="text" value="${profile.instruments}"></h4>
    <h4>Bio: <input class="edit-profile__description" type="text" size="70" value="${profile.description}"></h4>
    </section>
    <button class="edit-profile__submit" id="${profile.profileId}" value="${profile.profileId}">Update profile</button>
    `
}