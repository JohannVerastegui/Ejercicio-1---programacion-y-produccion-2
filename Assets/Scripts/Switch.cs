using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Switch : MonoBehaviour
{
    static void Main()
    {
        Console.Write("Ingresa un n�mero del 1 al 7: ");
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
                diaSemana = "Mi�rcoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "S�bado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                diaSemana = "N�mero inv�lido";
                break;
        }

        Console.WriteLine($"El n�mero {numero} corresponde a {diaSemana}.");
    }
}
