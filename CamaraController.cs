using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject target;
    //offset almacena la diferencia entre la camara y el jugador
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;

    }

    private void LateUpdate()
    {
        transform.position = target.transform.position + offset; 

    }
}
