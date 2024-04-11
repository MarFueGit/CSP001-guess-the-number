using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    // Clase abstracta que representa a un jugador en el juego de adivinar el número
    public abstract class Player
    {
        // Propiedad para almacenar el nombre del jugador
        public string Name { get; set; }

        // Lista para almacenar los números por turno
        protected List<int> guesses;

        // Constructor de la clase Player
        protected Player(string name)
        {
            Name = name;
            guesses = new List<int>();
        }

        // Método abstracto para que el jugador haga un intento de adivinar el número
        public abstract int MakeGuess();
    }
}
