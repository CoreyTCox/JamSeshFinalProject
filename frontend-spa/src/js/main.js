import Jam from "./components/jam";
import ProfileDetails from "./components/profileDetails";
import apiActions from "./api/apiActions";
import listProfiles from "./components/listProfiles";
import MyProfile from "./components/myProfile"
import ProfilePost from "./components/profilePost";
import ProfileEdit from "./components/profileEdit";

const appDiv = document.querySelector('#app');

export default function pageBuild() {
    ShowProfiles();
    navHome();
}

function navHome() {
    const homeButton = document.querySelector('.nav__profiles');
    homeButton.addEventListener('click', function () {
        appDiv.innerHTML = ShowProfiles();
    })
}

function ShowProfiles() {
    fetch("https://localhost:44372/api/Profile")
        .then(response => response.json())
        .then(profiles => {
            appDiv.innerHTML = listProfiles(profiles);
            console.log(profiles);

        })
        .catch(err => console.log(err))
}

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('add-profile__button')) {
        const addProfileSection = document.querySelector('.add-profile');
        addProfileSection.innerHTML = ProfilePost();
    }
})
appDiv.addEventListener("click", function () {
    if (event.target.classList.contains('add-profile__submit')) {
      const profileName = event.target.parentElement.querySelector('.add-profile__name').value;
      const profileLocation = event.target.parentElement.querySelector('.add-profile__location').value;
      const profileInstruments = event.target.parentElement.querySelector('.add-profile__instruments').value;
      const profileDescription = event.target.parentElement.querySelector('.add-profile__description').value;
      console.log("edit")
  
      var requestBody = {
        name: profileName,
        location: profileLocation,
        instruments: profileInstruments,
        description: profileDescription,
        image: "dummy image"
      }
      console.log(requestBody);
  
      apiActions.postRequest(
        "https://localhost:44372/api/Profile",
        requestBody,
        profiles => {
            appDiv.innerHTML = listProfiles(profiles);
        }
    )
    }
})

appDiv.addEventListener("click", function () {
    if (event.target.classList.contains('edit-profile__submit')) {
      const profileName = event.target.parentElement.querySelector('.edit-profile__name').value;
      const profileLocation = event.target.parentElement.querySelector('.edit-profile__location').value;
      const profileInstruments = event.target.parentElement.querySelector('.edit-profile__instruments').value;
      const profileDescription = event.target.parentElement.querySelector('.edit-profile__description').value;
      console.log("is here");
      const profileId = event.target.parentElement.querySelector('.edit-profile__submit').id;
        console.log("the profile id is " + profileId );
  
      var requestBody = {
        name: profileName,
        location: profileLocation,
        instruments: profileInstruments,
        description: profileDescription,
        image: "dummy image",
        id: profileId
      }
      console.log(requestBody);
  
      apiActions.postRequest(
        "https://localhost:44372/api/Profile",
        requestBody,
        profile => {
            appDiv.innerHTML = MyProfile(profile);
        }
    )
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('profile__edit_button')) {
        const profileId = event.target.parentElement.querySelector('.profile-details__button').id;
        apiActions.getRequest(
            `https://localhost:44372/api/Profile/${profileId}` ,
            profile => {
                appDiv.innerHTML = ProfileEdit(profile);
            }
        )
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('profile-details__button')) {
        const profileId = event.target.parentElement.querySelector('.profile-details__button').id;
        apiActions.getRequest(
            `https://localhost:44372/api/Profile/${profileId}` ,
            profile => {
                appDiv.innerHTML = ProfileDetails(profile);
            }
        )
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('nav__myprofile')) {
        const profileId = event.target.parentElement.querySelector('.nav__myprofile').id;
        apiActions.getRequest(
            `https://localhost:44372/api/Profile/${profileId}` ,
            profile => {
                appDiv.innerHTML = MyProfile(profile);
            }
        )
    }
})

appDiv.addEventListener('click', function(){
    if(event.target.classList.contains('delete-profile__button')){
        const profileId = event.target.parentElement.querySelector('.delete-profile__button').id;
        
        const profileCallback = () => {
            apiActions.getRequest(
                `https://localhost:44372/api/Profile/`,
                profiles => {
                    console.log("before listing profiles");
                    appDiv.innerHTML = listProfiles(profiles);
                    console.log("after listing profiles")
                })
        }

        apiActions.deleteRequest(
            `https://localhost:44372/api/Profile/${profileId}`,
            profileCallback
        )
    }
})