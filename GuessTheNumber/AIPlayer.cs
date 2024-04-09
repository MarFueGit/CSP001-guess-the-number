using System; // Esta línea importa el espacio de nombres System, proporcionando funcionalidades básicas del sistema.

namespace GuessTheNumber
{

    public class AIPlayer : Player
    {
        private Random random;
        
        public AIPlayer(string name) : base(name)
        {
            this.random = new Random ();
        }

        public override int MakeGuess()
        {
            int randomNumber = this.random.Next(1 ,100);
             Console.WriteLine($"Turno de la computadora, generando número aleatorio: {randomNumber}");
            return randomNumber;
        }
    }


}