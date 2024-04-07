using System;

namespace GuessTheNumber //Usamos namespace para organizar las clases
{
    public class Game {
        private int targetNumber;
        private Player player1;
        private bool win = false;

        public Game(){ // Change the access modifier to public
            //Generamos el numero aleatorio a adivinar
            this.RandomNumberGenerator();
            this.player1 = new Player("Mary");
        }

        private void RandomNumberGenerator(){
            Random r = new Random ();
            this.targetNumber = r.Next(1 ,100);
        }

        //Metodo para iniciar el juego
        public void startGame(){
            while (!this.win){
                this.player1.MakeGuess();
                this.checkGuess(this.player1.GetLastGuess(), this.targetNumber);
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
