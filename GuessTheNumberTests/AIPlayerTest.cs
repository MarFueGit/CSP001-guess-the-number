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
        // Arrange - Preparar
        string playerName = "AI";
        AIPlayer aiPlayer = new AIPlayer(playerName);

        // Act - Actuar
        int guess = aiPlayer.MakeGuess();

        // Assert - Verificar
        Assert.IsTrue(guess >= 1 && guess <= 100, "El número generado no está dentro del rango esperado.");
    }

    [TestMethod]
    public void TestMakeGuess_AddsGuessToGuessesList()
    {
        // Arrange - Preparar
        string playerName = "AI";
        AIPlayer aiPlayer = new AIPlayer(playerName);

        // Act - Actuar
        int guess = aiPlayer.MakeGuess();

        // Assert - Verificar
        CollectionAssert.Contains(aiPlayer.Guesses, guess, "La lista de suposiciones no contiene el número generado.");
    }

    [TestMethod]
    public void TestMakeGuess_UniqueGuesses()
    {
        // Arrange - Preparar
        string playerName = "AI";
        AIPlayer aiPlayer = new AIPlayer(playerName);

        // Act - Actuar
        int guess1 = aiPlayer.MakeGuess();
        int guess2 = aiPlayer.MakeGuess();

        // Assert - Verificar
        Assert.AreNotEqual(guess1, guess2, "Los números generados en diferentes llamadas no son únicos.");
    }
}

