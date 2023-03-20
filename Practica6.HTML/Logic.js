window.addEventListener("load", () => {
  
  //Selectores de clases
  
  let entry = document.querySelector(".entry");
  let clue = document.querySelector(".clue");
  let tryButton = document.querySelector(".try-button");
  let unknown = document.querySelector(".unknown");
  let scoreValue = document.querySelector(".score-value");
  let highscoreValue = document.querySelector(".highscore-value");
  let reinicio = document.querySelector(".reset-button");
  let body = document.querySelector("body");

  /**
   * LOGICA
   */

  //Valor de las vidas

  let score = 20;
  let array = [];
  let cont = 0;

  //Numero random
  
  let numRand = () => Math.floor(Math.random() * Math.floor(20)) + 1;
  let numero = numRand();
  
  //Main del juego

  tryButton.addEventListener("click", (e) => {
    if (entry.value == "" || entry.value == null || entry.value < 0 || entry.value > 20) {
      entry.value = 0;
      clue.textContent = "Número Inválido, Por Favor Ingrese un Número Entero entre 1 y 20";
    } else if (score <= 0) {
      clue.textContent = "Perdiste!";
      body.style.backgroundColor = 'red';
      tryButton.disabled = true;     
    } else {
      Comprobar();
    }
  });

  //Comprobar si acertó y Actualizar el score

  function Comprobar() {
    if (entry.value == numero) {
      clue.textContent = "Número Correcto";
      body.style.backgroundColor = 'rgba(36, 182, 46, 0.8)';
      tryButton.disabled = true;
      unknown.textContent = numero;
      scoreValue.textContent = score;
      array.push(score);
      Highscore();
    } else if (entry.value > numero) {
      clue.textContent = "Muy Alto!";
      unknown.textContent = "?";
      scoreValue.textContent = score -= 1;
    } else {
      clue.textContent = "Muy Bajo";
      unknown.textContent = "?";
      scoreValue.textContent = score -= 1;
    }
  }

  //HighScore

  function Highscore() {
    for (let i = 0; i < array.length; i++) {
      if (cont < array[i]) {
        cont = array[i];
        highscoreValue.textContent = score;
      }
    }
  }

  //Reiniciar el juego

  reinicio.addEventListener("click", () => {
    numero = numRand();
    score = 20;
    scoreValue.textContent = 20;
    clue.textContent = "Inténtalo!";
    entry.value = "";
    unknown.textContent = '?';
    body.style.backgroundColor = '';
    tryButton.disabled = false;  
  });
});
