using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IfandElse : MonoBehaviour
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El numero es negativo.");
        }
        else
        {
            Console.WriteLine("El numero es cero.");
        }
    }
}
