using System; // Esta línea importa el espacio de nombres System, proporcionando funcionalidades básicas del sistema.

namespace GuessTheNumber
{ //Este es un espacio de nombres que contiene la definicion de la clase player, ayuda a organizar y estructurar el codigo.
    public class Player
    {
        public string name = ""; //Atributo que almacena el nombre del jugador.
        private int lastGuess; // Atributo que almacena el ultimo intento del jugador.

        public Player(string name){ // Este metodo publico devuelve el valor del ultimo intento del jugador (lastGuess)
            this.lastGuess = 0;
            this.name = name;
        }

        //metodo para obtener el ultimo intento del player
        public int GetLastGuess(){
            return this.lastGuess;
        }

        public void MakeGuess(){ 
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