using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 5;
        float num2 = 1.7F;
        string text = "";

        num1 = (int)num2;
        Debug.Log(num1);

        text = num1.ToString();
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
