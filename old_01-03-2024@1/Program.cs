namespace _01_03_2024_1
{
    public class Program
    {
        public static void Main()
        {
            const double gravidade = 9.81;

            Console.WriteLine("Digite a altura da queda em metros:");
            double alturaQueda = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o intervalo de tempo em segundos para visualizar a queda:");
            double intervalo = Convert.ToDouble(Console.ReadLine());

            CalcularStatusFinal(gravidade, alturaQueda, out double tempoQueda, out double velocidadeImpacto, out double distanciaPercorrida);

            Console.WriteLine("Tempo de queda: {0:F2} segundos", tempoQueda);
            Console.WriteLine("Velocidade no momento do impacto: {0:F2} m/s", velocidadeImpacto);

            double tempoRestante, velocidadeInstantanea, distanciaPercorridaInstantanea;
            for (double segundo = 0; segundo <= (int)tempoQueda; segundo += intervalo)
            {
                CalcularStatusAtual(gravidade, tempoQueda, segundo, out tempoRestante, out velocidadeInstantanea, out distanciaPercorridaInstantanea);
                ExibirStatusAtual(distanciaPercorrida, segundo, tempoRestante, velocidadeInstantanea, distanciaPercorridaInstantanea);
            }

            CalcularStatusAtual(gravidade, tempoQueda, tempoQueda, out tempoRestante, out velocidadeInstantanea, out distanciaPercorridaInstantanea);
            ExibirStatusAtual(distanciaPercorrida, tempoQueda, tempoRestante, velocidadeInstantanea, distanciaPercorridaInstantanea);
        }

        public static void ExibirStatusAtual(double distanciaPercorrida, double segundo, double tempoRestante, double velocidadeInstantanea, double distanciaPercorridaInstantanea)
        {
            Console.WriteLine("\nSegundo: {0:F2}", segundo);
            Console.WriteLine("Tempo Restante: {0:F2} segundos", tempoRestante);
            Console.WriteLine("Velocidade Instantânea: {0:F2} m/s", velocidadeInstantanea);
            Console.WriteLine("Distância Percorrida: {0:F2} metros", distanciaPercorridaInstantanea);
            Console.WriteLine("Distância Restante: {0:F2} metros", distanciaPercorrida - distanciaPercorridaInstantanea);
            Console.WriteLine("------------------------------------------");
        }

        public static void CalcularStatusFinal(double gravidade, double alturaQueda, out double tempoQueda, out double velocidadeImpacto, out double distanciaPercorrida)
        {
            tempoQueda = Math.Sqrt(2 * alturaQueda / gravidade);
            velocidadeImpacto = gravidade * tempoQueda;
            distanciaPercorrida = 0.5 * gravidade * Math.Pow(tempoQueda, 2);
        }

        public static void CalcularStatusAtual(double gravidade, double tempoQueda, double segundo, out double tempoRestante, out double velocidadeInstantanea, out double distanciaPercorridaInstantanea)
        {
            tempoRestante = tempoQueda - segundo;
            velocidadeInstantanea = gravidade * segundo;
            distanciaPercorridaInstantanea = 0.5 * gravidade * Math.Pow(segundo, 2);
        }
    }
}