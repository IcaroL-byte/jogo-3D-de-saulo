using System;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour
{
    private Animator animator;
    private GameObject _player;
    public GameObject ataqueObject;
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao;
    private bool naVisao;
    
    private SphereCollider capsule;

    public float distanciaMinima = 1.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            _rigidbody = gameObject.GetComponent<Rigidbody>();
            velocidade = gameObject.GetComponent<Inimigo>().VelocidadeDoPersonagen();
            capsule = gameObject.GetComponent<SphereCollider>();
            animator = gameObject.GetComponent<Animator>();
            
            _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        capsule.radius = raioDeVisao;
        animator.SetBool("isWalking", false);
        
        if (Vector3.Distance(transform.position, _player.transform.position) > distanciaMinima)
        {
            if (naVisao == true)
            {
                transform.LookAt(_player.transform.position);
                transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);  
                animator.SetBool("isWalking", true);
            
            }
            ataqueObject.SetActive(false);
           
        }
        else
        {
            
            animator.SetTrigger("Attack");
            ataqueObject.SetActive(true);
        }
        
        
        
        Debug.DrawLine(transform.position, _player.transform.position, Color.red);
    }
    
    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
        }
    }
    
    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = false;
        }
    }
    
}
