using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    GameObject objeto;
    public GameObject[] go;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            objeto = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objeto.transform.position = new Vector3(5 * i, 0, 0);
            objeto.name = "Cube" + i;
            go[i] = objeto;
        }
    }

    
}
