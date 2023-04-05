using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio06 : MonoBehaviour
{
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject.CreatePrimitive(PrimitiveType.Sphere);

        if (objeto == null)
        {
            objeto = GameObject.Find("Sphere");
           
            objeto.transform.position = new Vector3(100, 0, 0);
        }

    }

}
