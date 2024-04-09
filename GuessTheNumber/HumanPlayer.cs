using System; // Esta línea importa el espacio de nombres System, proporcionando funcionalidades básicas del sistema.

namespace GuessTheNumber
{

    public class HumanPlayer : Player
    {

        public HumanPlayer(string name) : base(name) {
            
        }

        public override int MakeGuess()
        {
             Console.WriteLine($"{this.name}, introduce un número entero :\n");
                //leemos la entrada del teclado/usuario
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number)){
                    //Validamos el numero es entero
                return number;
            }else{
                return 0;
            }
        }
    }


}