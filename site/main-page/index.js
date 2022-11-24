const inputLogin = document.getElementById('log');
    const inputPassword = document.getElementById('passWord');
    const buttonLog = document.getElementById('li');

    buttonLog.addEventListener('click', () => {
        if(inputLogin.value ==='' && inputPassword.value === ''){
            alert("Введите свои данные, пожалуйста ;)");
        }
        else if(inputLogin.value === ''){
            alert("Вы не ввели свой логин, сударь");
        }
        else if(inputPassword.value === ''){
            alert("Вы не ввели свой пароль, сударь");
        }
        else{
            open('/login-page/index.html');
        }
    })
