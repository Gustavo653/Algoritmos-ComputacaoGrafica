namespace _01_03_2024_5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Bem-vindo ao calculador de Movimento Circular Uniforme!");

            Console.Write("Insira o raio da trajetória circular (em metros): ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Insira a velocidade angular (em rad/s): ");
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
            Console.WriteLine("Velocidade Angular: " + velocidadeAngular + " rad/s");
            Console.WriteLine("Velocidade Tangencial: " + velocidadeTangencial + " m/s");
            Console.WriteLine("Aceleração Centrípeta: " + aceleracaoCentripeta + " m/s^2");
        }
    }
}