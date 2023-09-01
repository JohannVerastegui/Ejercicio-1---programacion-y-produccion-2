using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Switch : MonoBehaviour
{
    static void Main()
    {
        Console.Write("Ingresa un número del 1 al 7: ");
        int numero = int.Parse(Console.ReadLine());

        string diaSemana;

        switch (numero)
        {
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miércoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "Sábado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                diaSemana = "Número inválido";
                break;
        }

        Console.WriteLine($"El número {numero} corresponde a {diaSemana}.");
    }
}
