namespace _01_03_2024_5
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Insira o raio da trajetória circular em metros: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Insira a velocidade angular em rad/s: ");
            double velocidadeAngular = double.Parse(Console.ReadLine());

            double velocidadeTangencial = CalcularVelocidadeTangencial(velocidadeAngular, raio);
            double aceleracaoCentripeta = CalcularAceleracaoCentripeta(velocidadeAngular, raio);

            ExibirResultados(velocidadeAngular, velocidadeTangencial, aceleracaoCentripeta);
        }

        public static double CalcularVelocidadeTangencial(double velocidadeAngular, double raio)
        {
            return velocidadeAngular * raio;
        }

        public static double CalcularAceleracaoCentripeta(double velocidadeAngular, double raio)
        {
            return Math.Pow(velocidadeAngular, 2) * raio;
        }

        public static void ExibirResultados(double velocidadeAngular, double velocidadeTangencial, double aceleracaoCentripeta)
        {
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Velocidade Angular: {0:F2} rad/s", velocidadeAngular);
            Console.WriteLine("Velocidade Tangencial: {0:F2} m/s", velocidadeTangencial);
            Console.WriteLine("Aceleração Centrípeta: {0:F2} m/s^2", aceleracaoCentripeta);
        }
    }
}