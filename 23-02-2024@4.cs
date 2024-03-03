using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Write("Digite a temperatura atual (em graus Celsius): ");
		double temperatura = Convert.ToDouble(Console.ReadLine());
		if (temperatura > 35)
			Console.WriteLine("A temperatura está acima de 35 graus Celsius. É recomendado utilizar protetor solar.");
		else
			Console.WriteLine("A temperatura está dentro da faixa considerada segura. Protetor solar pode ser opcional.");
	}
}
