using _01_03_2024_2;

namespace UnitTestProject
{
    public class TestesProgram
    {
        [Test]
        public void CalcularValoresIniciais()
        {
            double gravidade = 9.81;
            double velocidadeInicial = 10;
            double angulo = 45;

            Program.CalcularValoresIniciais(gravidade, velocidadeInicial, angulo, out double v0x, out double v0y, out double tempoMaximo, out double tempoAtual);

            Assert.Multiple(() =>
            {
                Assert.That(v0x, Is.EqualTo(7.071067811865476).Within(0.01));
                Assert.That(v0y, Is.EqualTo(7.071067811865476).Within(0.01));
                Assert.That(tempoMaximo, Is.EqualTo(1.4422205101855958).Within(0.01));
                Assert.That(tempoAtual, Is.EqualTo(0));
            });
        }

        [Test]
        public void CalcularPosicaoAtual()
        {
            double gravidade = 9.81;
            double intervalo = 0.1;
            double v0x = 7.071067811865476;
            double v0y = 7.071067811865476;
            double tempoAtual = 0;

            double tempoAtualizado = Program.CalcularPosicaoAtual(gravidade, intervalo, v0x, v0y, tempoAtual);

            Assert.That(tempoAtualizado, Is.EqualTo(0.1));
        }
    }
}