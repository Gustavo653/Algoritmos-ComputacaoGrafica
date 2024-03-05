namespace _01_03_2024_4
{
    public class Program
    {
        public static void Main()
        {
            const double gravidade = 9.81;

            Console.Write("Digite o comprimento da corda do pêndulo (em metros): ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o ângulo inicial em graus: ");
            double anguloInicial = Convert.ToDouble(Console.ReadLine());

            double anguloInicialRadiano = anguloInicial * Math.PI / 180.0;
            double periodo = 2 * Math.PI * Math.Sqrt(comprimento / gravidade);

            double tempo = 0;
            const double intervaloTempo = 1.0;
            double anguloAnterior = anguloInicialRadiano;

            while (true)
            {
                double anguloGraus = CalcularAngulo(gravidade, comprimento, anguloInicialRadiano, tempo);
                double velocidade = CalcularVelocidade(intervaloTempo, anguloAnterior, anguloGraus);

                Console.WriteLine("Tempo: {0:F2} s, Ângulo: {1:F2} graus, Velocidade: {2:F2} graus/s", tempo, anguloGraus, velocidade);
                anguloAnterior = anguloGraus;
                tempo += intervaloTempo;

                if (tempo >= periodo)
                    break;
            }
        }

        public static double CalcularVelocidade(double intervaloTempo, double anguloAnterior, double anguloGraus)
        {
            return (anguloGraus - anguloAnterior) / intervaloTempo * Math.PI / 180.0;
        }

        public static double CalcularAngulo(double gravidade, double comprimento, double anguloInicialRadiano, double tempo)
        {
            double angulo = anguloInicialRadiano * Math.Cos(Math.Sqrt(gravidade / comprimento) * tempo);
            double anguloGraus = angulo * 180.0 / Math.PI;
            return anguloGraus;
        }
    }
}