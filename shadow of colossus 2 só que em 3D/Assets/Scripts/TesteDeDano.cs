using System;
using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    private RabaRamit rabaRamit;

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.CompareTag("Inimigo"))
        {
            int vida_atual = rabaRamit.VidaDoPersonagen() - colisao.gameObject.GetComponent<Inimigo>().DanoDoInimigo();
            
            rabaRamit.SetVitalidade(vida_atual);
            Debug.Log("O personagem " +rabaRamit.NomeDoPersonagen()+" tem agora "+rabaRamit.VidaDoPersonagen());
        }
    }


    void Start()
    {
        rabaRamit = GetComponent<RabaRamit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
