namespace GuessTheNumberTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber; 

[TestClass]
public class PlayerTests
{
    [TestMethod]
    public void Constructor_SetsName()
    {
        // Arrange - Preparar
        string playerName = "TestPlayer";

        // Act - actuar
        Player player = new TestPlayer(playerName);

        // Assert - Verificar
        Assert.AreEqual(playerName, player.Name);
    }

    // Creo una subclase de la clase player para hacer el test este es el mock.
    private class TestPlayer : Player
    {
        // Constructor para el reproductor de prueba.
        public TestPlayer(string name) : base(name)
        {
        }

        // Implemento el método abstracto MakeGuess
        public override int MakeGuess()
        {
            // retornamos un numero mockeado para prueba.
            return 42;
        }
    }
}
