window.addEventListener('load', ()=>{

    //Selectores de clases
    let entry = document.querySelector('.entry');
    let clue = document.querySelector('.clue');
    let tryButton = document.querySelector('.try-button');
    let unknown = document.querySelector('.unknown');
    let scoreValue = document.querySelector('.score-value');
    let highscore = document.querySelector('.highscore-value');
    let reinicio = document.querySelector('.reset-button');

    /**
    * LOGICA
    */

    //Valor de las vidas
    let score = 20

    //Numero random
    let numRand = () => Math.floor(Math.random() * Math.floor(20)) +1;
    let numero = numRand()
    
    //Comprobar si acertó y Actualizar el score
    
    tryButton.addEventListener('click', ()=> {
        
        if(entry.value == numero){
            clue.textContent = 'Acertaste!'
            unknown.textContent= numero
            scoreValue.textContent = score
            highscore.textContent = score
            

        } else if( entry.value > numero){
            clue.textContent = 'Muy Alto!';
            unknown.textContent= '?'
            scoreValue.textContent= (score-=1)
        } else{
            clue.textContent = 'Muy Bajo';
            unknown.textContent= '?'
            scoreValue.textContent= (score-=1)
        }
        
    })

    //Reiniciar el juego

    reinicio.addEventListener('click', ()=> {

        

    })


    


    
    








})