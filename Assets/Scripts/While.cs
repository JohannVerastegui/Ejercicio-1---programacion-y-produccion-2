using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class While : MonoBehaviour
{
    static void Main()
    {
        int contador = 1;

        while (contador <= 5)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}
