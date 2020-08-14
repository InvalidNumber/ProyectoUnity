using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMeses : MonoBehaviour
{
    [Range(0, 12)]
    public int mes;
    // Start is called before the first frame update
    void Start()
    {
        switch (mes)
        {
            case 1:
                Debug.Log("Es enero.");
                break;
            case 2:
                Debug.Log("Es febrero.");
                break;
            case 3:
                Debug.Log("Es marzo.");
                break;
            case 4:
                Debug.Log("Es abril.");
                break;
            case 5:
                Debug.Log("Es mayo.");
                break;
            case 6:
                Debug.Log("Es junio.");
                break;
            case 7:
                Debug.Log("Es julio.");
                break;
            case 8:
                Debug.Log("Es agosto.");
                break;
            case 9:
                Debug.Log("Es septiembre.");
                break;
            case 10:
                Debug.Log("Es octubre.");
                break;
            case 11:
                Debug.Log("Es noviembre.");
                break;
            case 12:
                Debug.Log("Es diciembre.");
                break;
            default:
                Debug.Log("Mes no valido.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
