using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotation = new Vector3(15f, 30f, 45f);
    void Update()
    {
        
        transform.Rotate(rotation * Time.deltaTime);
    }

}
