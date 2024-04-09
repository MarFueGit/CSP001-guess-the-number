using System;

namespace GuessTheNumber //Usamos namespace para organizar y estructurar el codigo.
{
    public class Game {
        private int targetNumber; // atributo privado que contiene un numero random a adivinar
        private Player player1; //jugador 1
        private bool win = false; // esta variable nos dice si ya gano

        public Game(){ // Cambiamos el modificador de acceso a público
            //Generamos el numero aleatorio a adivinar
            this.RandomNumberGenerator();
            this.player1 = new Player("Mary");
        }

        private void RandomNumberGenerator(){ //Este método privado genera un número aleatorio que el jugador debe adivinar
            Random r = new Random ();//Utiliza la clase Rndom para generar un numero aleatorio entre 1 y 100.
            this.targetNumber = r.Next(1 ,100); // y se lo asigna al aributo targetNumber.
        }

        //Metodo publico para iniciar el juego
        public void startGame(){
            while (!this.win){ //Utilizamos el bucle While que continua ejecutandose mientras no haya ganador.
                this.player1.MakeGuess();
                this.checkGuess(this.player1.GetLastGuess(), this.targetNumber);//Verificamos si el intento es correcto llamando al metodo checkGuess().
            }
        }

        //Metodo para ver si el jugador adivino el numero
        public void checkGuess(int guess, int targetNumber){ // Cambiamos el modificador de acceso a publico
                    //Validamos el numero es entero
                    if (guess == targetNumber){
                        this.win = true;
                        Console.WriteLine("Haz adivinado!");
                    }else{
                        //Verificamos el número es mayor o menor que la entrada del usuario
                        bool esMayor = guess > this.targetNumber;
                        if (esMayor){
                            Console.WriteLine("Intenta con otro número! Uno menor \n");
                        }else{
                            Console.WriteLine("Intenta con otro número! Uno mayor \n");
                        }
            }
        }
    }
}
