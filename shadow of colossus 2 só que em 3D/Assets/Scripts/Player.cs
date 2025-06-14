using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    private bool _isGrounded;
    public float jumpForce = 5;
    
    private Animator _animation;
    public float velocidade = 10f;
    private bool _isWalking;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animation = GetComponent<Animator>();
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
        _animation.SetBool("Andando", false);
        _isWalking = false;
        
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime; 
            _animation.SetBool("Andando", true);    
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            _isWalking = true;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime; 
            _animation.SetBool("Andando", true);    
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            _isWalking = true;
        }
        
        
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime; 
            _animation.SetBool("Andando", true);    
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            _isWalking = true;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime; 
            _animation.SetBool("Andando", true);    
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            _isWalking = true;
        }

        
        
        transform.position = posicao;

        if (Input.GetKey(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            _isGrounded = false;
        }
        
       
        
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 45, 0);
            _isWalking =  true;
        }
        else
            
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 135, 0);
            _isWalking =  true;
        }
        else    
        
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -135, 0);
            _isWalking =  true;
        }
        else   
            
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -45, 0);
            _isWalking =  true;
        }
        
    }

    private void FixedUpdate()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetButtonDown("Fire1") && !_isWalking)
        {
            _animation.SetTrigger("Ataque");
        }
    }
    
}
