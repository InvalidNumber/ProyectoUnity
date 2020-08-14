using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [Header("variables publicas")]
    [Tooltip("variables de tipo entero por ejemplo")]
    [Range(0, 10)]
    public int numeroEntero = 10;
    public float numeroDecimal = 2.5f;
    [Space]
    public char letra = 'a';
    public string texto = "hola holita";
    public bool logica = false;
    public Vector3 posicion;
    [SerializeField]
    private int numerito;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(texto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
