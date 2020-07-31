export default function ProfilePost(profileId) {
    return `

<input class="add-profile__name" type="text" placeholder="Your Name">
<input class="add-profile__location" type="text" placeholder="Your Location">
<input class="add-profile__instruments" type="text" placeholder="Your Instruments">
<input class="add-profile__image" type="text" hidden="true" value="songbackground.jpg">
<input class="add-profile__description" type="text" placeholder="About You">
<input class="add-profile__id" type="text" hidden="true" id="${profileId}">
<button class="add-profile__submit">Save Profile</button>
    `
}