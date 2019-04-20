using System;

public abstract class Carro : ICarro
{
    //VIRTUAL PERMITE QUE O MÉTODO SEJA REESCRITO
    public virtual int CalcularQuantidadeDeLugares()
    {
        return 5;
    }

    public void Dirigir(bool? temCarta)
    {
        if(temCarta == true)
        {
            Console.WriteLine("Aprovado");
        }
        else if (temCarta == false)
        {
            Console.WriteLine("Reprovado");
        }     
        else{
            Console.WriteLine("Deu erro!");
        }
    }

    public void Dirigir()
    {
        throw new System.NotImplementedException();
    }
}

public static class Fiat147
{
    public static void Anda(ref string retorno)
    {
        retorno = "bablaldald";
    }
}

public class Citroen : Carro
{
}

public class Peugeout : Carro
{
    public void DirigirPeugeot(string cor)
    {
      switch (cor)
      {
          case "Azul":
              Console.WriteLine("Conversivel");
              break;
          case "Vermelha":
              Console.WriteLine("Carro mais feminino");
              break;
      }
    }
}

public class Moto
{
    public virtual int CalcularQuantidadeDeLugares()
    {
        return 5;
    }

    public void Dirigir()
    {
        
    }    
}

public class Spin : Carro
{
    //override "reescreve" o método
    public override int CalcularQuantidadeDeLugares()
    {
        return 8;
    }    
}

public interface ICarro
{
    void Dirigir();

    int CalcularQuantidadeDeLugares();
}