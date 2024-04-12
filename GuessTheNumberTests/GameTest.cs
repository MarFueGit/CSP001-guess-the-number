using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber;
using System.Reflection; // Import the System.Reflection namespace
namespace GameTests;

[TestClass]
public class GameTests
{
    [TestMethod]
    public void StartGame_HumanWins()
    {
        // Arrange
        var game = new Game(50, new MockPlayer("AI", 49), new MockPlayer("Human", 50));

        // Act
        game.StartGame();

        // Assert
        Assert.IsTrue(game.CheckGuess(50));
    }

    [TestMethod]
    public void StartGame_AIWins()
    {
        // Arrange
        var game = new Game(50, new MockPlayer("AI", 50), new MockPlayer("Human", 49));

        // Act
        game.StartGame();

        // Assert
        Assert.IsTrue(game.CheckGuess(50));
    }

    // Mock class to simulate player behavior for testing purposes
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
