namespace GuessTheNumberTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber; // Assuming your Player class is in the GuessTheNumber namespace

[TestClass]
public class PlayerTests
{
    [TestMethod]
    public void Constructor_SetsName()
    {
        // Arrange
        string playerName = "TestPlayer";

        // Act
        Player player = new TestPlayer(playerName);

        // Assert
        Assert.AreEqual(playerName, player.Name);
    }

    // Concrete subclass for testing purposes
    private class TestPlayer : Player
    {
        // Constructor for the test player
        public TestPlayer(string name) : base(name)
        {
        }

        // Implement the abstract MakeGuess method
        public override int MakeGuess()
        {
            // For testing purposes, just return a fixed guess
            return 42;
        }
    }
}
