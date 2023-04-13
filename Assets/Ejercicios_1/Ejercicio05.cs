using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 30 GameObjects al inicio
    /// </summary>
    public class Ejercicio05 : MonoBehaviour
    {
        public GameObject[] go;
        void Start()
        {
            for (int i = 0; i<30; i++)
            {
                go[i] = new GameObject();
            }
        } 
    }
}