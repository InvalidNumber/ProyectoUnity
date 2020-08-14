using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class NotaProfesor : MonoBehaviour
{
    [Range(0, 10)]
    public float cal1;
    [Range(0, 10)]
    public float cal2;
    [Range(0, 10)]
    public float cal3;
    // Start is called before the first frame update
    void Start()
    {
        float average=((cal1 + cal2 + cal3) /3);
        if(average >= 90)
        {
            Debug.Log("Sobresaliente");
        }
        else if(average >=70 && average < 90)
        {
            Debug.Log("Notable");
        }
        else if(average >= 50 && average < 70)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
