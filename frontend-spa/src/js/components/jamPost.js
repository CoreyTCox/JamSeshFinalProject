export default function JamPost(jamId) {
    return `

<input class="add-jam__name" type="text" placeholder="Jam Name">
<input class="add-jam__location" type="text" placeholder="Jam Location">
<input class="add-jam__description" type="text" placeholder="Jam Description">
<input class="add-jam__date" type="datetime-local" id="meeting-time" placeholder="Jam Date">
<label for="attcount">Number of Attendees:</label>
<select name="attcount" class="add-jam__attendees">
  <option value="1">1</option>
  <option value="2">2</option>
  <option value="3">3</option>
  <option value="4">4</option>
</select> 
<input class="add-jam__id" type="text" hidden="true" id="${jamId}">
<input class="add-jam__image" type="text" hidden="true" value="songbackground.jpg">
<button class="add-jam__submit">Save Jam</button>
    `
}
