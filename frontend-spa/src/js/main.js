import Jam from "./components/jam";
import ProfileDetails from "./components/profileDetails";
import apiActions from "./api/apiActions";
import ListProfiles from "./components/listProfiles";
import MyProfile from "./components/myProfile"
import ProfilePost from "./components/profilePost";
import ProfileEdit from "./components/profileEdit";
import ListJams from "./components/listJams";
import JamDetails from "./components/jamDetails";
import JamPost from "./components/jamPost";
import JamEdit from "./components/jamEdit";
import ProfileLogin from "./components/profileLogin";
import Map from "./components/map";
import listJams from "./components/listJams";

const appDiv = document.querySelector('#app');
const mapDiv = document.querySelector("#map");
const topDiv = document.querySelector('#BackToTop');


export default function pageBuild() {
    navHome();
    // ShowProfiles();
    // ShowJams();
    // navJams();
    initMap();
    // toggleMap();
    showLogon();
}

function initMap() {

    console.log("entered initmap");
    let map = new google.maps.Map(document.getElementById("map"), {
        center: {
            lat: 41.140179,
            lng: -81.863589
        },
        zoom: 12
    });

    const myLatLng = {
        lat: 41.140179,
        lng: -81.863589
    };

    const myLatLng2 = {
        lat: 41.040179,
        lng: -81.863589
    };

    new google.maps.Marker({
        position: myLatLng,
        map,
        title: "High Voltage Acoustic Rock"
    });

    new google.maps.Marker({
        position: myLatLng2,
        map,
        title: "Castle Noel Big Band"
    });


    var position1 = { lat: 41.040179, lng: -81.843589 };
    new google.maps.Marker({
        position: position1,
        map,
        title: "Church Lot Duet"
    });

}

function showLogon() {
    appDiv.innerHTML = ProfileLogin();
    // toggleTopOn();
}

function navHome() {
    const myProfileButton = document.querySelector('.nav__myprofile');
    myProfileButton.addEventListener('click', function () {
        toggleMapOff();
        appDiv.innerHTML = ProfileLogin();
    })

    const profilesButton = document.querySelector('.nav__profiles');
    profilesButton.addEventListener('click', function () {
        toggleMapOff();
        appDiv.innerHTML = ShowProfiles();
    })

    const jamsButton = document.querySelector('.nav__jams');
    jamsButton.addEventListener('click', function () {
        toggleMapOn();
        appDiv.innerHTML = ShowJams();
    })
}

function ShowProfiles() {
    fetch("https://localhost:44372/api/Profile")
        .then(response => response.json())
        .then(profiles => {
            appDiv.innerHTML = ListProfiles(profiles);
            console.log(profiles);

        })
        .catch(err => console.log(err))
}


function toggleMapOn() {
    mapDiv.style.display = "block";
}

function toggleMapOff() {
    mapDiv.style.display = "none";
}

// function toggleTopOn() {
//     topDiv.style.display = "block";
// }


function ShowJams() {
    console.log("jams");
    fetch("https://localhost:44372/api/Jam")
        .then(response => response.json())
        .then(jams => {
            appDiv.innerHTML = ListJams(jams);
            console.log(jams);
            
        })
        .catch(err => console.log(err))
    }
    
appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('add-profile__button')) {
        const addProfileSection = document.querySelector('.add-profile');
        addProfileSection.innerHTML = ProfilePost();
        // appDiv.innerHTML = ProfilePost();

    }
})

appDiv.addEventListener("click", function () {
    if (event.target.classList.contains('add-profile__submit')) {
        const profileName = event.target.parentElement.querySelector('.add-profile__name').value;
        const profileLocation = event.target.parentElement.querySelector('.add-profile__location').value;
        const profileInstruments = event.target.parentElement.querySelector('.add-profile__instruments').value;
        const profileDescription = event.target.parentElement.querySelector('.add-profile__description').value;
        const profilePassword = event.target.parentElement.querySelector('.add-profile__password').value;
        console.log("edit")

        var requestBody = {
            name: profileName,
            location: profileLocation,
            instruments: profileInstruments,
            description: profileDescription,
            password: profilePassword,
            image: "dummy image"
        }
        console.log(requestBody);

        apiActions.postRequest(
            "https://localhost:44372/api/Profile",
            requestBody,
            profiles => {
                appDiv.innerHTML = ListProfiles(profiles);
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
        //const profilePassword = event.target.parentElement.querySelector('.edit-profile__password').value;
        const navButton = document.querySelector('.nav__myprofile');
        console.log("is here");
        const profileId = event.target.parentElement.querySelector('.edit-profile__submit').id;
        console.log("the profile id is " + profileId);
        
        var requestBody = {
            name: profileName,
            location: profileLocation,
            instruments: profileInstruments,
            description: profileDescription,
            //password: profilePassword,
            image: "dummy image",
            profileId: profileId,
            password: "Welcome"
        }
        console.log(requestBody);
        
        apiActions.putRequest(
            `https://localhost:44372/api/Profile/${profileId}`,
            requestBody,
            profile => {
                appDiv.innerHTML = ProfileDetails(profile);
                navButton.innerHTML = profileName;
            })
            console.log(requestBody);
            
            apiActions.putRequest(
                `https://localhost:44372/api/Profile/${profileId}`,
                requestBody,
                profile => {
                    appDiv.innerHTML = ProfileDetails(profile);
                }
                )
            }
        })

        appDiv.addEventListener('click', function () {
            if (event.target.classList.contains('profile-edit__button')) {
                //const profileId = event.target.parentElement.querySelector('.profile__edit_button').id;
                const profileId = document.querySelector('.nav__myprofile').id;
        if (profileId == "0") {
            window.alert("not logged in")
        }
        else {
            apiActions.getRequest(
                `https://localhost:44372/api/Profile/${profileId}`,
                profile => {
                    appDiv.innerHTML = ProfileEdit(profile);
                }
            )
        }
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('profile-details__button')) {
        const profileId = event.target.parentElement.querySelector('.profile-details__button').id;
        apiActions.getRequest(
            `https://localhost:44372/api/Profile/${profileId}`,
            profile => {
                appDiv.innerHTML = ProfileDetails(profile);
            }
            )
        }
})

appDiv.addEventListener("click", ()=> {
    if (event.target.classList.contains("continue-as-guest")){
        ShowJams();
        toggleMapOn();
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('nav__myprofile')) {
        const profileId = event.target.parentElement.querySelector('.nav__myprofile').id;
        apiActions.getRequest(
            `https://localhost:44372/api/Profile/${profileId}`,
            profile => {
                appDiv.innerHTML = MyProfile(profile);
            }
        )
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('delete-profile__button')) {
        //const profileId = event.target.parentElement.querySelector('.delete-profile__button').id;
        const profileId = document.querySelector('.nav__myprofile').id;
        const navButton = document.querySelector('.nav__myprofile');
        if (profileId == "0") {
            window.alert("not logged in")
        }
        else {
            const profileCallback = () => {
                apiActions.getRequest(
                    `https://localhost:44372/api/Profile/`,
                    profiles => {
                        console.log("before listing profiles");
                        navButton.innerHTML = "My Profile";
                        appDiv.innerHTML = ListProfiles(profiles);
                        console.log("after listing profiles")
                    })
            }
            apiActions.deleteRequest(
                `https://localhost:44372/api/Profile/${profileId}`,
                profileCallback
            )
        }
    }
})

//**********************************JAMS******************************************************* */

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('jam-details__button')) {
        console.log("jam details1")
        const jamId = event.target.parentElement.querySelector('.jam-details__button').id;
        apiActions.getRequest(
            `https://localhost:44372/api/Jam/${jamId}`,
            jam => {
                appDiv.innerHTML = JamDetails(jam);
            }
        )
    }
})

appDiv.addEventListener("click", function () {
    if (event.target.classList.contains('edit-jam__submit')) {
        const jamName = event.target.parentElement.querySelector('.edit-jam__name').value;
        const jamLocation = event.target.parentElement.querySelector('.edit-jam__location').value;
        const jamDescription = event.target.parentElement.querySelector('.edit-jam__description').value;
        const jamDate = event.target.parentElement.querySelector('.edit-jam__date').value;
        const jamAttendees = event.target.parentElement.querySelector('.edit-jam__attendees').value;
        //const jamProfileId = event.target.parentElement.querySelector('.edit-jam__profileId').value;
        console.log("jam edit is here");
        const jamId = event.target.parentElement.querySelector('.edit-jam__submit').id;
        console.log("the jam id is " + jamId);

        var requestBody = {
            name: jamName,
            location: jamLocation,
            description: jamDescription,
            eventDate: jamDate,
            maxNumberOfAttendees: jamAttendees,
            image: "dummy image",
            jamId: jamId
        }
        console.log(requestBody)

        apiActions.putRequest(
            `https://localhost:44372/api/Jam/${jamId}`,
            requestBody,
            jam => {
                console.log("in put")
                appDiv.innerHTML = JamDetails(jam);
            }
        )
    }
    toggleMapOff();
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('jam__edit_button')) {
        console.log("jam edit clicked");
        const jamId = event.target.parentElement.querySelector('.jam__edit_button').id;
        const profileId = document.querySelector('.nav__myprofile').id;
        console.log("jam id is " + jamId + " profile id is " + profileId);
        if (profileId == "0" || profileId != jamId) {
            window.alert("not logged in");
        }
        else {
            apiActions.getRequest(
                `https://localhost:44372/api/Jam/${jamId}`,
                jam => {
                    appDiv.innerHTML = JamEdit(jam);
                }
            )
        }
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('delete-jam__button')) {
        const jamId = event.target.parentElement.querySelector('.delete-jam__button').id;
        const profileId = document.querySelector('.nav__myprofile').id;
        if (profileId == "0" || profileId != jamId) {
            window.alert("not logged in")
        }
        else {
            const jamCallback = () => {
                apiActions.getRequest(
                    `https://localhost:44372/api/Jam/`,
                    jams => {
                        console.log("before listing jams");
                        appDiv.innerHTML = ListJams(jams);
                        console.log("after listing jams")
                    })
            }
            apiActions.deleteRequest(
                `https://localhost:44372/api/Jam/${jamId}`,
                jamCallback
            )
        }
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('add-jam__button')) {
        const addJamSection = document.querySelector('.add-jam');
        const profileId = document.querySelector('.nav__myprofile').id;
        if (profileId == "0") {
            window.alert("not logged in")
        }
        else {

            addJamSection.innerHTML = JamPost();
        }
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('logon-profile__submit')) {

        const logonName = event.target.parentElement.querySelector('.logon-profile__name').value;
        const logonPassword = event.target.parentElement.querySelector('.logon-profile__password').value;
        const navButton = document.querySelector('.nav__myprofile');

        apiActions.getRequest(
            `https://localhost:44372/api/Profile/${logonName}/${logonPassword}`,
            profile => {
                navButton.innerHTML = profile.name;
                navButton.id = profile.profileId;
                if (profile.profileId != 100) {
                    toggleMapOn();
                    ShowJams();
                }
                if (logonName != profile.name || logonPassword != profile.password){
                    window.alert("invalid login");
                }
            }
        )
    }
})

appDiv.addEventListener("click", function () {
    if (event.target.classList.contains('add-jam__submit')) {
        const jamName = event.target.parentElement.querySelector('.add-jam__name').value;
        const jamLocation = event.target.parentElement.querySelector('.add-jam__location').value;
        const jamDescription = event.target.parentElement.querySelector('.add-jam__description').value;
        const jamDate = event.target.parentElement.querySelector('.add-jam__date').value;
        const jamAttendees = event.target.parentElement.querySelector('.add-jam__attendees').value;
        console.log("add jam")
        var requestBody = {
            name: jamName,
            location: jamLocation,
            description: jamDescription,
            eventDate: jamDate,
            maxNumberOfAttendees: jamAttendees,
            image: "dummy image",
            profileId: 1
        }
        console.log(requestBody);
        apiActions.postRequest(
            "https://localhost:44372/api/Jam",
            requestBody,
            jams => {
                appDiv.innerHTML = ListJams(jams);
            }
        )
    }
})


appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('jam__joinJam_button')) {
        console.log("button clicked")
        //const addJamAttendeeSection = document.querySelector('.jam-addProfile');
        const jamId = event.target.id;
        const profileId = document.querySelector('.nav__myprofile').id;
        //addJamAttendeeSection.innerHTML = JamDetails();
        var requestBody = {
            jamID: jamId,
            profileID: profileId
        }
        console.log(requestBody);
        console.log(profileId);
        if (profileId == "0") {
            window.alert("not logged in")
        }
        else {
            console.log("after if")
            apiActions.postRequest(
                "https://localhost:44372/api/ProfileJam",
                requestBody,
                profileJams => {
                    console.log(profileJams);
                    apiActions.getRequest(
                        `https://localhost:44372/api/Jam/${jamId}`,
                        jam => {
                            console.log("in get request");
                            console.log(jam);
                            appDiv.innerHTML = JamDetails(jam);
                        }
                    )
                }
            )
        }
    }
})

appDiv.addEventListener('click', function () {
    if (event.target.classList.contains('jam__leaveJam_button')) {
        console.log("button clicked");
        const jamId = event.target.parentElement.querySelector('.jam__leaveJam_button').id;
        console.log("after jamId");
        const profileId = document.querySelector('.nav__myprofile').id;
        console.log("after profileId" + profileId);
        //profileIdundefined
        if (profileId == "0") {
            window.alert("not logged in")
        }
        else {
            console.log("after If")
            const jamDetailsCallback = () => {
                apiActions.getRequest(
                    `https://localhost:44372/api/Jam/${jamId}`,
                    jam => {
                        console.log("before removed");
                        console.log("jam id is " + jamId + " and profile id is " + profileId);
                        appDiv.innerHTML = JamDetails(jam);
                        console.log("after removed");
                    })
            }
            apiActions.deleteRequest(
                `https://localhost:44372/api/ProfileJam/${jamId}/${profileId}`,
                jamDetailsCallback
            )
        }
    }
})

