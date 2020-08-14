using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcular : MonoBehaviour
{
    public string operacion;
    public short num1;
    public short num2;
    // Start is called before the first frame update
    void Start()
    {
        switch (operacion)
        {
            case "+":
            case "sumar":
                Debug.Log(num1 + num2);
                break;
            case "-":
            case "restar":
                Debug.Log(num1 - num2);
                break;
            case "*":
            case "multiplicar":
                Debug.Log(num1 * num2);
                break;
            case "/":
            case "dividir":
                Debug.Log(num1 / num2);
                break;
            default:
                Debug.Log("Operacion no valida");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
