using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    public GameObject objeto;
    
    // Start is called before the first frame update
    void Start()
    {
        
       
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
        if(objeto == null)
        {
            objeto = GameObject.Find("Sphere");
            Rigidbody body = objeto.AddComponent<Rigidbody>();
        }
        
    }
   
    
}
