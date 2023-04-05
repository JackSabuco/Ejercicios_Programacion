using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio07 : MonoBehaviour
{
    public GameObject objeto;
    public GameObject objeto2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
      

        if (objeto == null && objeto2 == null)
        {
            objeto = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            objeto2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            objeto.transform.position = new Vector3(100, 0, 0);
            objeto2.transform.position = new Vector3(200, 0, 0);
        }

    }

    // Update is called once per frame
   
}
