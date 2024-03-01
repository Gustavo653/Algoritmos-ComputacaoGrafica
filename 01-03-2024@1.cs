using System;

public class Program
{
	public static void Main()
	{
		const double gravidade = 9.81;
		
		Console.WriteLine("Digite a altura da queda em metros:");
		double alturaQueda = Convert.ToDouble(Console.ReadLine());

		double tempoQueda = Math.Sqrt((2 * alturaQueda) / gravidade);
		double velocidadeImpacto = gravidade * tempoQueda;
		double distanciaPercorrida = 0.5 * gravidade * Math.Pow(tempoQueda, 2);
		
		Console.WriteLine("Tempo de queda: {0:F2} segundos", tempoQueda);
		Console.WriteLine("Velocidade no momento do impacto: {0:F2} m/s", velocidadeImpacto);
	}
}
