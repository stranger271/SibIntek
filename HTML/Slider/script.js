let slides = document.getElementsByClassName("item"); 
let slideIndex=0;
changeSlide(1); 

function changeSlide(val) {
  slideIndex = slideIndex + val;

  if (slideIndex > slides.length){slideIndex = 1}
  if (slideIndex < 1){slideIndex = slides.length}
  
  for (let slide of slides) {
    slide.classList.remove('active');
  }

  slides[slideIndex - 1].classList.add('active'); 
  console

}

   
 

