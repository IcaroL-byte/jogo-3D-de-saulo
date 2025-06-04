using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Inimigo inimigo;
    private int ataque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int AtaqueDoInimigo()
    {
        ataque = inimigo.DanoDoInimigo();
        return ataque;
    }
}
