using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber;
using System.Reflection; 
namespace GameTests;

[TestClass]
public class GameTests
{
    [TestMethod]
    public void StartGame_HumanWins()
    {
        // Arrange - Preparar
        var game = new Game(50, new MockPlayer("AI", 49), new MockPlayer("Human", 50));

        // Act - Actuar
        game.StartGame();

        // Assert - Verificar
        Assert.IsTrue(game.CheckGuess(50));
    }

    [TestMethod]
    public void StartGame_AIWins()
    {
        // Arrange - Preparar
        var game = new Game(50, new MockPlayer("AI", 50), new MockPlayer("Human", 49));

        // Act - Actuar
        game.StartGame();

        // Assert - Verificar
        Assert.IsTrue(game.CheckGuess(50));
    }

    // Mock para simular el comportamiento del jugador con fines de prueba
    public class MockPlayer : Player
    {
        private readonly int guess;

        public MockPlayer(string name, int guess) : base(name)
        {
            this.guess = guess;
        }

        public override int MakeGuess()
        {
            Guesses.Add(guess);
            return guess;
        }
    }
}
