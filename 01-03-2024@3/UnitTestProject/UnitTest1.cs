using _01_03_2024_3;

namespace UnitTestProject
{
    public class TestesProgram
    {
        [Test]
        public void TestCriarVetor()
        {
            // Arrange
            string input = "2,5 3,5";
            Console.SetIn(new StringReader(input));

            // Act
            double[] result = Program.CriarVetor();

            Assert.Multiple(() =>
            {
                // Assert
                Assert.That(result[0], Is.EqualTo(2.5));
                Assert.That(result[1], Is.EqualTo(3.5));
            });
        }

        [Test]
        public void TestCalcularVelocidadeFinal()
        {
            // Arrange
            double[] velocidadeInicialA = [2.0, 3.0];
            double[] velocidadeInicialB = [1.0, 2.0];
            double massaA = 5.0;
            double massaB = 3.0;

            // Act
            double[] result = Program.CalcularVelocidadeFinal(velocidadeInicialA, velocidadeInicialB, massaA, massaB);

            Assert.Multiple(() =>
            {
                // Assert
                Assert.That(result[0], Is.EqualTo(1.25));
                Assert.That(result[1], Is.EqualTo(2.25));
            });
        }
    }
}