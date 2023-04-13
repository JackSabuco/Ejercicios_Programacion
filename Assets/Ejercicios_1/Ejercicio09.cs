using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        GameObject objeto;
        public GameObject[] go;
        void Start()
        {
            //❗️
            /*
            for(int i = 0; i < 12; i++)
            {
                objeto = GameObject.CreatePrimitive(PrimitiveType.Cube); //Sphere
                objeto.transform.position = new Vector3(5 * i, 0, 0); //Arbitrario
                objeto.transform.localScale = Vector3.one * (i + 1); //No es el doble que el anterior
                go[i] = objeto;
            }
            */

            Ejercicio08.CrearFiguras(PrimitiveType.Sphere, 12);
        }
    }
}