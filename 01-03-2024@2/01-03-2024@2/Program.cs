namespace _01_03_2024_2
{
    public class Program
    {
        public static void Main()
        {
            const double gravidade = 9.81;

            Console.WriteLine("Digite a velocidade inicial em m/s:");
            double velocidadeInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o ângulo de lançamento em graus:");
            double angulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o intervalo de tempo em segundos:");
            double intervalo = Convert.ToDouble(Console.ReadLine());

            CalcularValoresIniciais(gravidade, velocidadeInicial, angulo, out double v0x, out double v0y, out double tempoMaximo, out double tempoAtual);

            while (tempoAtual <= tempoMaximo)
            {
                tempoAtual = CalcularPosicaoAtual(gravidade, intervalo, v0x, v0y, tempoAtual);
            }

            Console.WriteLine("Tempo final: {0:F2} s, Posição final: (X:0, Y:0) m", tempoMaximo);
        }

        public static void CalcularValoresIniciais(double gravidade, double velocidadeInicial, double angulo, out double v0x, out double v0y, out double tempoMaximo, out double tempoAtual)
        {
            double anguloRadiano = angulo * Math.PI / 180;
            v0x = velocidadeInicial * Math.Cos(anguloRadiano);
            v0y = velocidadeInicial * Math.Sin(anguloRadiano);
            tempoMaximo = (2 * v0y) / gravidade;
            tempoAtual = 0;
        }

        public static double CalcularPosicaoAtual(double gravidade, double intervalo, double v0x, double v0y, double tempoAtual)
        {
            double x = v0x * tempoAtual;
            double y = v0y * tempoAtual - 0.5 * gravidade * tempoAtual * tempoAtual;
            Console.WriteLine("Tempo: {0:F2} s, Posição: (X:{1:F2}, Y:{2:F2}) m", tempoAtual, x, y);
            tempoAtual += intervalo;
            return tempoAtual;
        }
    }
}