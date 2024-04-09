using System;

namespace GuessTheNumber //Usamos namespace para organizar y estructurar el codigo.
{
    public class Game {
        private int targetNumber; // atributo privado que contiene un numero random a adivinar
        private Player _humanPlayer; //jugador 1
        private Player _AIPlayer; //jugador 2
        private bool win = false; // esta variable nos dice si ya gano

        public Game(){ // Cambiamos el modificador de acceso a público
            //Generamos el numero aleatorio a adivinar
            this.RandomNumberGenerator();
            this._humanPlayer = new HumanPlayer("Mary");
            this._AIPlayer = new AIPlayer("Computadora");
        }

        private void RandomNumberGenerator(){ //Este método privado genera un número aleatorio que el jugador debe adivinar
            Random r = new Random ();//Utiliza la clase Rndom para generar un numero aleatorio entre 1 y 100.
            this.targetNumber = r.Next(1 ,100); // y se lo asigna al aributo targetNumber.
        }

        //Metodo publico para iniciar el juego
        public void startGame(){
            while (!this.win){ //Utilizamos el bucle While que continua ejecutandose mientras no haya ganador.
              //Empezamos con HumanPlayer, con su intento
              int player1Number = this._humanPlayer.MakeGuess();
              if (this.checkGuess(player1Number, this.targetNumber))
              {
                Console.WriteLine($"{this._humanPlayer.name} ha ganado \n");
              }else{
                int computerNumber = this._AIPlayer.MakeGuess();
                if (this.checkGuess(computerNumber, this.targetNumber))
                {
                    Console.WriteLine($"{this._AIPlayer.name} ha ganado \n");
                }
              }  
            }
        }

        //Metodo para ver si el jugador adivino el numero
        public bool checkGuess(int guess, int targetNumber){ // Cambiamos el modificador de acceso a publico
                    //Validamos el numero es entero
                    if (guess == targetNumber){
                        this.win = true;
                        return true;
                    }else{
                        //Verificamos el número es mayor o menor que la entrada del usuario
                        bool esMayor = guess > this.targetNumber;
                        if (esMayor){
                            Console.WriteLine("Intenta con otro número! Uno menor \n");
                        }else{
                            Console.WriteLine("Intenta con otro número! Uno mayor \n");
                        }
                        return false;
            }
        }
    }
}
