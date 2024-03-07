using _01_03_2024_5;

namespace UnitTestProject
{
    public class ProgramTest
    {
        [Test]
        public void CalcularVelocidadeTangencial()
        {
            // Arrange
            double raio = 5.0;
            double velocidadeAngular = 2.0;
            double expectedVelocidadeTangencial = velocidadeAngular * raio;

            // Act
            double result = Program.CalcularVelocidadeTangencial(velocidadeAngular, raio);

            // Assert
            Assert.That(result, Is.EqualTo(expectedVelocidadeTangencial));
        }

        [Test]
        public void CalcularAceleracaoCentripeta()
        {
            // Arrange
            double raio = 5.0;
            double velocidadeAngular = 2.0;
            double expectedAceleracaoCentripeta = Math.Pow(velocidadeAngular, 2) * raio;

            // Act
            double result = Program.CalcularAceleracaoCentripeta(velocidadeAngular, raio);

            // Assert
            Assert.That(result, Is.EqualTo(expectedAceleracaoCentripeta));
        }
    }
}