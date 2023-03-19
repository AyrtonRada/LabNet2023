window.addEventListener('load', ()=>{

    //Selectores de clases
    let entry = document.querySelector('.entry');
    let clue = document.querySelector('.clue');
    let tryButton = document.querySelector('.try-button');
    
    /**
    * LOGICA
    */

    //Numero random
    let numRand = () => Math.floor(Math.random() * Math.floor(20)) +1;
    let numero = numRand()
    
    //Comprobar si acertó
    
    tryButton.addEventListener('click', ()=> {
        
        if(entry.value == numero){
            clue.textContent = 'Acertaste!';
        } else if( entry.value > numero){
            clue.textContent = 'Muy Alto!';
        } else{
            clue.textContent = 'Muy Bajo';
        }

    })











})