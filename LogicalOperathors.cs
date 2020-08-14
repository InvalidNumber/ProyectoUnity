using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperathors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("(5 == 5 OR 4 == 3 ) AND (1 < 5 AND 3 ==3) es " + ((5 == 5 || 4 == 3) && (1 < 5 && 3 == 3)));
        Debug.Log("1 + 2 > 3 OR 1 - 1 < 0 es " + ((1 + 2 > 3) || (1 - 1 < 0)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
