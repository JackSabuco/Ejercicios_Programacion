using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        objeto = GameObject.Find("Cube");
        objeto.transform.position = new Vector3(111.1f, -5f, 4.5f);
    }

   

}
