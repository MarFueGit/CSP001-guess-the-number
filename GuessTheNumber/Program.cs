using System;  // Importa el espacio de nombres a utilizar Systen proporciona funcionalidades basicas del sistema.
using GuessTheNumber; // Este es un Namespace personalizado llamado GuessTheNumber

class Program
{
    static void Main(string[] args)
    {
        Game game = new();
        game.StartGame(); // Iniciamos el juego
    }
}
