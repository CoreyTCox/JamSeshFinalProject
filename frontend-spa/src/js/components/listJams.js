import moment from "moment";
export default function listJams(jams){
return `
            
        <section class="info-collection">
            ${jams.map(jam => {
                return `
                
                <section class="info-details">
                    <img src="images/${jam.image}" alt="${jam.image}" width="500" height="auto">
                    <button class="jam-details__button" id="${jam.jamId}">Jam Details</button>
        </section>
       
    `
}).join("")}           
</section>
<section id="add-jam" class="add-jam">
<a href="#add-jam"><img style="border-color: black;" class="add-jam__button" src="images/create.png" alt="Create a Sesh" width="40px" height="40px"></a>
        </section>
`
}