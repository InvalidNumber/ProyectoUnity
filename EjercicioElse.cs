using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioElse : MonoBehaviour
{
    public int numerito = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(numerito < 0){
            Debug.Log("El numero es negativo.");
        }
        else if(numerito > 0)
        {
            Debug.Log("El numero es positivo.");
        }
        else if(numerito == 0)
        {
            Debug.Log("El numero es 0, neutro.");
        }
        if((numerito % 2) == 0)
        {
            Debug.Log("El numero es par.");

        }
        else if((numerito % 2) != 0)
        {
            Debug.Log("El numero es impar.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
