using UnityEngine;

public class InimigoMovimento : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao;
    private bool naVisao;
    
    private CapsuleCollider capsule;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            _rigidbody = gameObject.GetComponent<Rigidbody>();
        
            capsule = gameObject.GetComponent<CapsuleCollider>();
            
            _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
