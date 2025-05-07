using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    private bool _isGrounded;
    public float jumpForce = 5;
    
    public float velocidade = 10f;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Certifique-se de que o chão tem a tag "Ground"
        {
            _isGrounded = true;
        }
    }

    /*
    void onCollisionExit(Collision collision)
    {
        _isGrounded = false;
    }
    */
    
    void Update()
    {
        Vector3 posicao = transform.position;
        
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime; 
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime; 
        }
        
        
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime; 
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        
        transform.position = posicao;

        if (Input.GetKey(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            _isGrounded = false;
        }
    }

   
    
}
