using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere una esfera al inicio con un Rigidbody añadido
    /// </summary>
    public class Ejercicio04 : MonoBehaviour
    {
        public GameObject objeto;
        
        void Start()
        {            
            if(objeto == null)
            {
                objeto = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Rigidbody body = objeto.AddComponent<Rigidbody>();
            }
        }
    }
}