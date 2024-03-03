using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Insira um ano para verificar se ele é bissexto:");
		var ano = Console.ReadLine();
		var ehBissexto = DateTime.IsLeapYear(Convert.ToInt32(ano));
		Console.WriteLine("O ano " + ano + " é bissexto? " + (ehBissexto ? "Sim" : "Não"));
	}
}
