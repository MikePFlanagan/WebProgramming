function validate() {
    
    document.getElementById('user-name-error').style.visibility = 'hidden';
    document.getElementById('pass-word-error').style.visibility = 'hidden';

    var UserName = document.getElementById('user-name').value;
    var PassWord = document.getElementById('pass-word').value;

    if (UserName == '') {
        document.getElementById('user-name-error').style.visibility = 'visible';
        return;
    }

    if (PassWord == '') {
        document.getElementById('pass-word-error').style.visibility = 'visible';
        return;
    }

    window.location = 'index.html';
}