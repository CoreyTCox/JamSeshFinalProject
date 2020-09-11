import moment from "moment";
export default function listJams(jams){
return `
            
        <ul class="info-collection">
            ${jams.map(jam => {
                return `
                
                <section class="info-details">
                    <li><h3 class="jam__name" id="${jam.jamId}">Title: ${jam.name}</h3>
                    <li><div>${jam.description}</div>
                    <li><h3>Where: ${jam.location}</h3>
                    <li><h3>When: ${moment(jam.eventDate).format('MMM DD, h:mm a')}</h3>
                    <div id="jamIcon">
                    <button class="jam-details__button" id="${jam.jamId}">Jam Details</button>
            </li>
        </section>
       
    `
}).join("")}           
</ul>
<section id="add-jam" class="add-jam">
<a href="#add-jam"><img style="border-color: black;" class="add-jam__button" src="images/create.png" alt="Create a Sesh" width="40px" height="40px"></a>
        </section>
`
}