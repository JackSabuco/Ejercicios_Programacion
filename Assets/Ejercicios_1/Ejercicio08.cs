using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio08 : MonoBehaviour
{
    public GameObject objeto;
    public GameObject objeto2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);


       
        
            objeto = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objeto2 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        objeto.transform.position = new Vector3(5, 0, 0);
        objeto.transform.localScale = Vector3.one * 2f;

        objeto2.transform.position = new Vector3(10, 0, 0);
        objeto2.transform.localScale = objeto.transform.localScale * 2;
       




    }

   
}
