using System;

namespace GuessTheNumber //Usamos namespace para organizar las clases
{
    public class Game {
        private int targetNumber;
        private Player player1;
        private bool win = false;

        public Game(){ // Change the access modifier to public
            //Generamos el numero aleatorio a adivinar
            Random r = new Random ();
            this.targetNumber = r.Next(1 ,100);

            this.player1 = new Player("Mary");
        }

        //Metodo para ver si el jugador adivino el numero
        public void checkGuess(){ // Change the access modifier to public
            while (!win){
                    this.player1.MakeGuess();
                    //Validamos el numero es entero
                    if (this.player1.lastGuess == this.targetNumber){
                        this.win = true;
                        Console.WriteLine("Haz adivinado!");
                    }else{
                        //Verificamos el número es mayor o menor que la entrada del usuario
                        bool esMayor = this.player1.lastGuess > this.targetNumber;
                        if (esMayor){
                            Console.WriteLine("Intenta con otro número! Uno menor \n");
                        }else{
                            Console.WriteLine("Intenta con otro número! Uno mayor \n");
                        }
                    }
                
            }
        }
    }
}
