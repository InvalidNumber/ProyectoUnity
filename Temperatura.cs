using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperatura : MonoBehaviour
{
    public short temperatura = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(temperatura > 60)
        {
            Debug.Log("Vamos a morir todos.");
        }
        else if(temperatura > 30)
        {
            Debug.Log("Hace calor.");
        }
        else if(temperatura < 20)
        {
            Debug.Log("Hace frio");
        }
        else
        {
            Debug.Log("La temperatura es ideal");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
