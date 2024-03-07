using _01_03_2024_1;

namespace UnitTestProject
{
    [TestFixture]
    public class TestesProgram
    {
        [Test]
        public void CalcularStatusFinal()
        {
            const double gravidade = 9.81;
            double alturaQueda = 10;

            Program.CalcularStatusFinal(gravidade, alturaQueda, out double tempoQueda, out double velocidadeImpacto, out double distanciaPercorrida);

            Assert.Multiple(() =>
            {
                Assert.That(tempoQueda, Is.EqualTo(1.4278431229270645).Within(0.0001));
                Assert.That(velocidadeImpacto, Is.EqualTo(14.007141035914504).Within(0.0001));
                Assert.That(distanciaPercorrida, Is.EqualTo(10.000000000000002).Within(0.0001));
            });
        }

        [Test]
        public void CalcularStatusAtual()
        {
            const double gravidade = 9.81;
            double tempoQueda = 2.0248456731316584;
            double segundo = 1;

            Program.CalcularStatusAtual(gravidade, tempoQueda, segundo, out double tempoRestante, out double velocidadeInstantanea, out double distanciaPercorridaInstantanea);

            Assert.Multiple(() =>
            {
                Assert.That(tempoRestante, Is.EqualTo(1.0248456731316584).Within(0.0001));
                Assert.That(velocidadeInstantanea, Is.EqualTo(9.81).Within(0.0001));
                Assert.That(distanciaPercorridaInstantanea, Is.EqualTo(4.905).Within(0.0001));
            });
        }

        [Test]
        public void ExibirStatusAtual()
        {
            double distanciaPercorrida = 49.05;
            double segundo = 2.0;
            double tempoRestante = 0.0;
            double velocidadeInstantanea = 19.62;
            double distanciaPercorridaInstantanea = 49.05;

            using StringWriter sw = new();
            Console.SetOut(sw);
            Program.ExibirStatusAtual(distanciaPercorrida, segundo, tempoRestante, velocidadeInstantanea, distanciaPercorridaInstantanea);
            string expectedOutput = string.Format(
                "\nSegundo: {0:F2}\r\nTempo Restante: {1:F2} segundos\r\nVelocidade Instant�nea: {2:F2} m/s\r\nDist�ncia Percorrida: {3:F2} metros\r\nDist�ncia Restante: {4:F2} metros\r\n------------------------------------------\r\n",
                segundo,
                tempoRestante,
                velocidadeInstantanea,
                distanciaPercorridaInstantanea,
                distanciaPercorrida - distanciaPercorridaInstantanea);
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}