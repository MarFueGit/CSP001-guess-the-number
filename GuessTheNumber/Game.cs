using System;

namespace GuessTheNumber //Usamos namespace para organizar las clases
{
    public class Game {
        private int targetNumber;
        private bool win = false;

        public Game(){ // Change the access modifier to public
            //Generamos el numero aleatorio a adivinar
            Random r = new Random ();
            this.targetNumber = r.Next(1 ,100);
        }

        //Metodo para ver si el jugador adivino el numero
        public void makeGuess(){ // Change the access modifier to public
            while (!win){
                Console.WriteLine("Por favor, introduce un número entero :\n");
                //leemos la entrada del teclado/usuario
                string input = Console.ReadLine();
                // Convertimos la entrada del usuario a entero
                if (int.TryParse(input, out int number)){
                    //Validamos el numero es entero
                    if (number == this.targetNumber){
                        this.win = true;
                        Console.WriteLine("Haz adivinado!");
                    }else{
                        //Verificamos el número es mayor o menor que la entrada del usuario
                        bool esMayor = number > this.targetNumber;
                        if (esMayor){
                            Console.WriteLine("Intenta con otro número! Uno menor \n");
                        }else{
                            Console.WriteLine("Intenta con otro número! Uno mayor \n");
                        }
                    }
                }else{
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número entero válido.");
                }
            }
        }
    }
}
