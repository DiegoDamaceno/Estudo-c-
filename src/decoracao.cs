using System;
public class Decoracao
{
    public int valorTotal = 0;
    public string Nome;

    public Decoracao()
    {
        Nome = "BRUNA E DIEGO";
        valorTotal = 10;
    }

    public void Enfeite()
    {
        Console.WriteLine("Chapeu");
    }

    public void CalculaPrecoEnfeite(int valor)
    {        
        valorTotal = valorTotal + valor;
    }
}