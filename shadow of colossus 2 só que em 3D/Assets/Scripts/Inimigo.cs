using UnityEngine;

public class Inimigo : RabaRamit
{
    [SerializeField] 
    private ArmaduraDoInimigo armadura;
   [SerializeField] 
    private ArmaDoInimigo enimArma;
   
    public enum ArmaDoInimigo
    {
        ESPADA, KATANA , AIDS
    }

    public enum ArmaduraDoInimigo
    {
        DIVINA, ESMERALDA , DIAMANTE
    }

    public void MudarArmadura(ArmaduraDoInimigo armadura)
    {
        this.armadura = armadura;
    }

    public ArmaduraDoInimigo Armadura
    {
        get { return this.armadura; }
    }

    public void MudarArma(ArmaDoInimigo arma)
    {
        this.enimArma = arma;
    }

    public ArmaDoInimigo Arma
    {
        get {return this.enimArma;}
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (enimArma)
        {
            case ArmaDoInimigo.ESPADA:
                dano = AtaqueDoPersonagen() + 10;
                break;
            case ArmaDoInimigo.KATANA:
                dano = AtaqueDoPersonagen() + 18;
                break;
            case ArmaDoInimigo.AIDS:
                dano = AtaqueDoPersonagen() + 5;
                break;
        }
        
        // dano do ataque com a arma
        
        return dano;
    }
    
}
