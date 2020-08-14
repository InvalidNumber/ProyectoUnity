using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioProgramacion : MonoBehaviour
{
    public int A = 2;
    public int B = 3;
    // Start is called before the first frame update

    void Start()
    {

        if (A < B)
        {
            Debug.Log("B es mayor que A.");
        }
        else if (B < A)
        {
            Debug.Log("A es mayor que B.");
        }
        if (A == B)
        {
            Debug.Log("A y B son iguales.");
        }
        else if (A != B)
        {
            Debug.Log("Los numeros son distintos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
