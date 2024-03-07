using _01_03_2024_4;

namespace UnitTestProject
{
    public class TestesProgram
    {
        [Test]
        public void AnguloCalculadoCorretamente()
        {
            // Arrange
            const double gravidade = 9.81;
            double comprimento = 1.0;
            double tempo = 2.0;
            double anguloInicialRadiano = 45 * Math.PI / 180.0;

            // Act
            double anguloCalculado = Program.CalcularAngulo(gravidade, comprimento, anguloInicialRadiano, tempo);

            // Assert
            Assert.That(anguloCalculado, Is.EqualTo(44.99).Within(0.01));
        }

        [Test]
        public void VelocidadeCalculadaCorretamente()
        {
            // Arrange
            const double gravidade = 9.81;
            double comprimento = 1.0;
            double tempo = 2.0;

            // Act
            double velocidadeCalculada = Program.CalcularVelocidade(comprimento, gravidade, tempo);

            // Assert
            Assert.That(velocidadeCalculada, Is.EqualTo(-0.13).Within(0.01));
        }
    }
}