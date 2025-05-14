using System;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour
{
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
            
            _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        capsule.radius = raioDeVisao;
        
        if (Vector3.Distance(transform.position, _player.transform.position) > distanciaMinima)
        {
            if (naVisao == true)
            {
                transform.LookAt(_player.transform.position);
                transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);  
            
            
            }
            ataqueObject.SetActive(false);
        }
        else
        {

            
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
