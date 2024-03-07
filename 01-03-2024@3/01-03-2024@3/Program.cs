namespace _01_03_2024_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite as massas das partículas:");
            Console.Write("A:"); double massaA = Convert.ToDouble(Console.ReadLine());
            Console.Write("B:"); double massaB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite as velocidades iniciais das partículas (separadas por espaço):");
            Console.Write("A:"); double[] velocidadeInicialA = CriarVetor();
            Console.Write("B:"); double[] velocidadeInicialB = CriarVetor();

            double[] velocidadeFinalA = CalcularVelocidadeFinal(velocidadeInicialA, velocidadeInicialB, massaA, massaB);
            double[] velocidadeFinalB = CalcularVelocidadeFinal(velocidadeInicialB, velocidadeInicialA, massaB, massaA);

            Console.WriteLine("Velocidade final da partícula A: ({0}, {1}) m/s", velocidadeFinalA[0], velocidadeFinalA[1]);
            Console.WriteLine("Velocidade final da partícula B: ({0}, {1}) m/s", velocidadeFinalB[0], velocidadeFinalB[1]);
        }

        public static double[] CriarVetor()
        {
            string[] vetorUsuario = Console.ReadLine().Split(' ');
            double[] vetor = [Convert.ToDouble(vetorUsuario[0]), Convert.ToDouble(vetorUsuario[1])];
            return vetor;
        }

        public static double[] CalcularVelocidadeFinal(double[] velocidadeInicialA, double[] velocidadeInicialB, double massaA, double massaB)
        {
            double[] velocidadeFinal =
            [
                (massaA - massaB) / (massaA + massaB) * velocidadeInicialA[0] + 2 * massaB / (massaA + massaB) * velocidadeInicialB[0],
                (massaA - massaB) / (massaA + massaB) * velocidadeInicialA[1] + 2 * massaB / (massaA + massaB) * velocidadeInicialB[1],
            ];
            return velocidadeFinal;
        }
    }
}