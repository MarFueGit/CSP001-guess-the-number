namespace GuessTheNumberTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessTheNumber; // Assuming your Player class is in the GuessTheNumber namespace

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
    public void Method_MakeGuess_Return_OK()
    {
        // numero a regresar
        int numberExpected = 10;

        //Actuamos
        Player player = new HumanPlayer("Mary");
        // mandamos a llamar a la clase mock y le pasamos el numero simulado
        var consoleInputReader = new TestConsoleInputReader("10");
        Console.SetIn(consoleInputReader);

        int numberPlayer = player.MakeGuess();
        // Assert - Verificar
        Assert.AreEqual(numberExpected, numberPlayer);

    }

     public void Method_MakeGuess_Return_0()
    {
        // numero a regresar
        int numberExpected = 0;

        //Actuamos
        Player player = new HumanPlayer("Mary");
        // mandamos a llamar a la clase mock y le pasamos el numero simulado
        var consoleInputReader = new TestConsoleInputReader("Mary\n");
        Console.SetIn(consoleInputReader);

        int numberPlayer = player.MakeGuess();
        // Assert - Verificar
        Assert.AreEqual(numberExpected, numberPlayer);

    }

    // Mock para simular la entrada del teclado del usuario
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
