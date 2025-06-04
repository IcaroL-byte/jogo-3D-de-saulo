using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public RabaRamit personagem;
        private int ataque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int AtaqueDoPersonagem()
    {
        ataque = personagem.AtaqueDoPersonagen(); 
        return ataque;
    }
}
