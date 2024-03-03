using System;

public class Program
{
	public static void Main()
	{
		int primeiroNumero = 0, segundoNumero = 1, proximoNumero, quantidadeElementos;
		Console.Write("Insira o número para calcular a sequência de fibonacci: ");
		quantidadeElementos = int.Parse(Console.ReadLine());
		Console.Write(primeiroNumero + " " + segundoNumero + " ");
		for (int i = 2; i < quantidadeElementos; i++)
		{
			proximoNumero = primeiroNumero + segundoNumero;
			Console.Write(proximoNumero + " ");
			primeiroNumero = segundoNumero;
			segundoNumero = proximoNumero;
		}
	}
}
