document.getElementById('aadhaar-form').addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent form submission

    // Validate Name (only alphabets)
    var name = document.getElementById('name').value;
    var nameRegex = /^[A-Za-z\s]+$/;
    if (!nameRegex.test(name)) {
        alert("Please enter a valid name (only alphabets allowed).");
        return;
    }

    // Validate Mobile Number (only numbers, 10 digits)
    var mobile = document.getElementById('mobile').value;
    var mobileRegex = /^[0-9]{10}$/;
    if (!mobileRegex.test(mobile)) {
        alert("Please enter a valid mobile number (10 digits only).");
        return;
    }

    // Validate Aadhaar Number (only numbers, 12 digits)
    var aadhaar = document.getElementById('aadhaar').value;
    var aadhaarRegex = /^[0-9]{12}$/;
    if (!aadhaarRegex.test(aadhaar)) {
        alert("Please enter a valid Aadhaar number (12 digits only).");
        return;
    }

    // Validate Gender (only alphabets)
    var gender = document.getElementById('gender').value;
    var genderRegex = /^[A-Za-z]+$/;
    if (!genderRegex.test(gender)) {
        alert("Please enter a valid gender (only alphabets allowed).");
        return;
    }

    alert("Form submitted successfully!");
});
