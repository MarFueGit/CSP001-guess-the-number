using System; // Esta línea importa el espacio de nombres System, proporcionando funcionalidades básicas del sistema.

namespace GuessTheNumber
{ //Este es un espacio de nombres que contiene la definicion de la clase player, ayuda a organizar y estructurar el codigo.
    public abstract class Player
    {
        public string name = ""; //Atributo que almacena el nombre del jugador.
        public int lastGuess; // Atributo que almacena el ultimo intento del jugador.

        public List<int> guesses;

        protected Player(string name){ // Este metodo publico devuelve el valor del ultimo intento del jugador (lastGuess)
            this.lastGuess = 0;
            this.name = name;
            this.guesses = new List<int>();
        }

        //metodo para obtener el ultimo intento del player
        public int GetLastGuess(){
            return this.lastGuess;
        }

        public abstract int MakeGuess();

    }

}