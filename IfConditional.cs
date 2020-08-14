using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfConditional : MonoBehaviour
{
    // Start is called before the first frame update



    public int num1 = 5;
    public int num2 = 8;
    public void Start()
    {
        Debug.Log(num1);
        if (num1 < num2)
        {
            Debug.Log("Num1 es menor que Num2");
        }
    }
}
       


    