using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GuessTheNumber;
namespace AIPlayerTests;

[TestClass]
public class AIPlayerTests
{
    [TestMethod]
    public void TestMakeGuess_ReturnsNumberInRange()
    {
        // Arrange
        string playerName = "AI";
        AIPlayer aiPlayer = new AIPlayer(playerName);

        // Act
        int guess = aiPlayer.MakeGuess();

        // Assert
        Assert.IsTrue(guess >= 1 && guess <= 100, "El número generado no está dentro del rango esperado.");
    }

    [TestMethod]
    public void TestMakeGuess_AddsGuessToGuessesList()
    {
        // Arrange
        string playerName = "AI";
        AIPlayer aiPlayer = new AIPlayer(playerName);

        // Act
        int guess = aiPlayer.MakeGuess();

        // Assert
        CollectionAssert.Contains(aiPlayer.Guesses, guess, "La lista de suposiciones no contiene el número generado.");
    }

    [TestMethod]
    public void TestMakeGuess_UniqueGuesses()
    {
        // Arrange
        string playerName = "AI";
        AIPlayer aiPlayer = new AIPlayer(playerName);

        // Act
        int guess1 = aiPlayer.MakeGuess();
        int guess2 = aiPlayer.MakeGuess();

        // Assert
        Assert.AreNotEqual(guess1, guess2, "Los números generados en diferentes llamadas no son únicos.");
    }
}

