using System;
using System.Collections.Generic;

public class MergeNames
{
    public static List<string> UniqueNames(string[] names1, string[] names2)
    {
        List<string> nomes3 = new List<string>();
        bool achou = false;
        int contador = 0;
        int contador2 = 0;
        while(contador < names1.Length)
        {
            while (contador2 < nomes3.Count)
            {
             if (names1[contador] == nomes3 [contador2])
             {
                 achou = true;
                 
             } 
            contador2++;   
            }
            if(achou == false && names1[contador] != null)
            {
                nomes3.Add(names1[contador]);
            }
            contador++;
        }
        contador = 0;
        contador2 = 0;
        achou = false;
        while(contador < names2.Length)
        {
            while (contador2 < nomes3.Count)
            {
             if (names2[contador] == nomes3 [contador2])
             {
                 achou = true;
                 break;
             } 
            contador2++;   
            }
			contador2 = 0;
            if(achou == false)
            {
				 nomes3.Add(names2[contador]);
            }
            contador++;
			achou = false;
        }
        return nomes3;
    }
    
    public static void Main(string[] args)
    {
        string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}