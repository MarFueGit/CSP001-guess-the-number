namespace HumanPlayerTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber;

[TestClass]
public class HumanPlayerTest
{
    [TestMethod]
    public void Constructor_SetsName()
    {
        // Arrange - Preparar
        string playerName = "Mary";

        // Act - Actuar
        Player player = new HumanPlayer(playerName);

        // Assert - Verificar
        Assert.AreEqual(playerName, player.Name);
    }

    [TestMethod]
    public void Method_MakeGuess_ReturnsCorrectNumber()
    {
        // Arrange
        int numberExpected = 10;
        var consoleInputReader = new TestConsoleInputReader("10");
        Console.SetIn(consoleInputReader);
        Player player = new HumanPlayer("Mary");

        // Act
        int numberPlayer = player.MakeGuess();

        // Assert
        Assert.AreEqual(numberExpected, numberPlayer);
    }

    [TestMethod]
    public void Method_MakeGuess_ReturnsZeroOnNonNumericInput()
    {
        // Arrange
        int numberExpected = 0;
        var consoleInputReader = new TestConsoleInputReader("Mary\n");
        Console.SetIn(consoleInputReader);
        Player player = new HumanPlayer("Mary");

        // Act
        int numberPlayer = player.MakeGuess();

        // Assert
        Assert.AreEqual(numberExpected, numberPlayer);
    }

    /* Mock para simular la entrada del teclado del usuario
     prueba el comportamiento del jugador humano en diferentes escenarios de entrada.*/
     
    public class TestConsoleInputReader : System.IO.TextReader
    {
        private readonly string input;
        private bool inputConsumed = false;

        public TestConsoleInputReader(string input)
        {
            this.input = input;
        }

        public override string ReadLine()
        {
            if (!inputConsumed)
            {
                inputConsumed = true;
                return input;
            }
            return null;
        }
    }
}

