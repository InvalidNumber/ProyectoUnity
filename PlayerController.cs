using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Text countText;
    public Text winText;


    public float groundRayLength= 0.80f;
    public float yDeathLimit = -10f;

    public bool Grounded;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundRayLength);
    }

    public float jumpForce = 5f;
    private short contador = 0;
    public float speed = 10f;
    short targetContador = 7;
    protected Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
        
        
    }

    private void Update()
    {
        
        if (transform.position.y < yDeathLimit)
        {
            ResetLevel();
            //reset el nivel
        }
    }
    //metodo recomendado por unity para meter las fisicas dentro
    private void FixedUpdate()
    {
        //recoge el imput del teclado
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        //funcion de boton saltar8hecha por mi)
        /*if(Input.GetKey(KeyCode.Space) && Grounded == true)
        {
            Vector3 atas = new Vector3(0, 2, 0);
            rb.AddForce(atas * speed, ForceMode.Impulse);
        }   
        */
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            //con rb.velocity reseteamos la velocidad en y
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
        }
        //le metemos más velocidad
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjetoPickable"))
        {

            other.gameObject.SetActive(false);
            if (contador < targetContador)
            {
                contador = (short)(contador + 1);
                SetCountText();
                Debug.Log("Has recogido " + contador + " coleccionables.");
                if (contador >= targetContador)
                {
                    UpdateWinText(true);
                    Invoke("BackToLevelSelector", 3f);
                }
                
            }


        }
        
    }
    private void SetCountText()
    {
        countText.text = contador.ToString();
    }
    private void UpdateWinText(bool value)
    {
        winText.gameObject.SetActive(value);
    }
    private void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //funcion de salto(comprobar que esta en el suelo, hecjo por mi, deberia ponerse en start y update)
    /*private void CheckifGrounded()
    {
        if(transform.position.y > 0.5)
        {
            Grounded = false;
        }
        else 
        {
            Grounded = true;
        }

    }
    */
    private bool IsGrounded()
    {
        //se usa .down en vez de transform.up porque el eje pude moverse(sobretodo con una esfera)
        /*if(Physics.Raycast(transform.position, Vector3.down, groundRayLength)) {
            return true;
        }
        return false;*/
        return Physics.Raycast(transform.position, Vector3.down, groundRayLength);
    }
    private void BackToLevelSelector()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
