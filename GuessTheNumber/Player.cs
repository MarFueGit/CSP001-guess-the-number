using System;

namespace GuessTheNumber
{ //Usamos namespace para organizar las clases
    public class Player
    {
        private string name = "";
        public int lastGuess;

        public Player(string name){
            this.lastGuess = 0;
            this.name = name;
        }

        public void MakeGuess(){ //ponemos el operador ? porque puede retonar nullo
            Console.WriteLine($"{this.name}, introduce un número entero :\n");
                //leemos la entrada del teclado/usuario
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number)){
                    //Validamos el numero es entero
                   this.lastGuess = number;
                }
        }

    }

}