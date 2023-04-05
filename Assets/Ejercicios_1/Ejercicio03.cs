using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    public GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        objeto = GameObject.Find("Cube");
        objeto.transform.localScale = Vector3.one * 2f;


    }

 
}
