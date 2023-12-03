let index = 1;

function addNewPlace(event) {
    event.preventDefault();

    let form = document.querySelector('#studentsForm');

    let template = `<legend>Telebe-${index + 1}</legend>
        <label>
            Adi
        </label>
        <input name="students[${index}].Name" />
        <br />
        <label>
            Soyadi
        </label>
        <input name="students[${index}].Surname" />
        <br />`;

    let fieldSet = document.createElement('fieldset');
    fieldSet.innerHTML = template;
    document.querySelector('#addNew').before(fieldSet);

    index++;
}