using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un cubo al inicio y duplique su escala
    /// </summary>
    public class Ejercicio03 : MonoBehaviour
    {
        public GameObject objeto;

        void Start()
        {
            objeto = GameObject.Find("Cube");
            objeto.transform.localScale = Vector3.one * 2f;
            //❕ objeto.transform.localScale *= 2f;
        }
    }
}