export default function ProfileLogin() {
    return `
<section class="Logon">
<div class="Welcome">
<h1>Welcome to JamSesh!</h1>
<h2><span id="signIn">Sign In As Jammer</span> or <span id="continue">Continue As Groupie</span></h2>
</div>
<h3>Username</h3>  
<input class="logon-profile__name" type="text" placeholder="Enter your username">
<h3>Password</h3>
<input class="logon-profile__password" type="text" placeholder="Enter your password">
</br>
</br>
</br>
<div class="logon-profile__submit">Ready To Jam</div>
</br>
<div class="continue-as-guest">I'm Just A Groupie</div>
</br>
<div>You can sign up to become our newest Jammer on the Jammers page!</div>
</br>
</section>
<div class="SideImages">
<div id="leftImage">
<img src="images/RedSpaceImage1.png" alt="guitarist" height="450" width="250">
</div>
<div id="rightImage">
<img src="images/RedSpaceImage2.png" alt="drummer" height="450" width="250">
</div>
</div>

    `
}