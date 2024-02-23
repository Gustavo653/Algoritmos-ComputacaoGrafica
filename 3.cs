using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número para exibir a tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tabuada do " + numero);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + numero * i);
        }
    }
}
