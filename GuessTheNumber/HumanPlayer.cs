using System;

namespace GuessTheNumber
{
    // Clase que representa a un jugador humano en el juego de adivinar el número
    public class HumanPlayer : Player
    {
        // Constructor de la clase HumanPlayer que llama al constructor de la clase base (Player)
        public HumanPlayer(string name) : base(name)
        {
        }

        // Método para que el jugador humano haga un intento de adivinar el número
        public override int MakeGuess()
        {
            Console.WriteLine($"{Name}, introduce un número entero:");
            string input = Console.ReadLine(); // Leemos la entrada del usuario desde la consola
            if (int.TryParse(input, out int number))
            {
                // Agregamos el numero ingresao a la lista de suposiciuones
                guesses.Add(number);
                return number; // Si la entrada es un número entero válido, lo retornamos
            }
            else
            {
                Console.WriteLine("Entrada inválida. Inténtalo de nuevo."); // Mensaje de error si la entrada no es válida
                return MakeGuess(); // Llamada recursiva al método para solicitar nuevamente la entrada
            }
        }
    }
}



