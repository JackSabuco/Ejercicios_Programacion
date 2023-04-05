using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    public GameObject objeto;
    public GameObject[] go;
    void Start()
    {
        objeto = GameObject.Find("Cube");
        for (int i = 0; i<30; i++)
        {
            go[i] = objeto;
        }

    }

  
}
