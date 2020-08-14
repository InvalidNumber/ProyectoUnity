using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationalOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("10 < 2 = " + (10 < 2));
        Debug.Log("3* 5 >= 25 =" + (3 * 5 >= 25));
        Debug.Log("15 % 5 == 0 = " + (15 % 5 == 0));
        Debug.Log("10 < 10 = " + (10 < 10));
        Debug.Log("10 <= 10 = " + (10 <= 10));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
