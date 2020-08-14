using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class InsertaNota : MonoBehaviour
{
    [Range(0, 10)]
    public byte Nota;
    // Start is called before the first frame update
    void Start()
    {
        switch (Nota)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                Debug.Log("La nota es " + Nota + ",estas suspenso.");
                break;
            case 5:
                Debug.Log("La nota es " + Nota + ",aprobado.");
                break;
            case 6:
                Debug.Log("La nota es " + Nota + ",bien.");
                break;
            case 7:
            case 8:
                Debug.Log("La nota es " + Nota + ",notable.");
                break;
            case 9:
            case 10:
                Debug.Log("La nota es " + Nota + ". Sobresaliente!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
