var my_form = document.getElementById('my-form');

my_form.addEventListener("submit", function(e){
      
  e.preventDefault();
  
    const password = document.getElementById('password'); 
    const email = document.getElementById('email'); 
    const mailFormat = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;

    let valid = true;

    //проверка Почты
    if ( mailFormat.test(email.value)==false) {
      email.nextSibling.nextSibling.classList.add("visible"); 
      valid = false;
    } else {
      email.nextSibling.nextSibling.classList.remove("visible");
    }
   
    //проверка пароля
    if(password.value == ""){
      password.nextSibling.nextSibling.classList.add("visible"); 
      valid = false;  
    }else{
      password.nextSibling.nextSibling.classList.remove("visible");
    }

    if(valid){
      console.log("email="+email.value + ", password="+ password.value);
    }else{
      console.log("Пользователь ввел неверные данные!");
    }


  });
