using System;

namespace GuessTheNumber
{
    // Clase que representa a un jugador de la IA en el juego de adivinar el número
    public class AIPlayer : Player
    {
        private Random random; // Campo para generar números aleatorios

        // Constructor de la clase AIPlayer que llama al constructor de la clase base (Player) y crea una instancia de Random
        public AIPlayer(string name) : base(name)
        {
            random = new Random();
        }

        // Método para que la IA haga un intento de adivinar el número
        public override int MakeGuess()
        {
            int randomNumber = random.Next(1, 100); // Genera un número aleatorio entre 1 y 100
            //Agregamos el numero a la lista de supociones
            guesses.Add(randomNumber);
            Console.WriteLine($"Turno de la computadora, generando número aleatorio: {randomNumber}");
            return randomNumber; // Retorna el número aleatorio generado
        }
    }
}
