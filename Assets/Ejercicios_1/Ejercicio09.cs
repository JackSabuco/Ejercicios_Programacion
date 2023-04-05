using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
     GameObject objeto;
    public GameObject[] go;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 12; i++)
        {
            objeto = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objeto.transform.position = new Vector3(5 * i, 0, 0);
            objeto.transform.localScale = Vector3.one * (i + 1);
            go[i] = objeto;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
