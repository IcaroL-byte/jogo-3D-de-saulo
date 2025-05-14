using UnityEngine;

public class RabaRamit : MonoBehaviour
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private int vitalidade;
    [SerializeField]
    private int forca_ataque;
    [SerializeField]
    private int forca_pulo;
    [SerializeField]
    private int velocidade;
    [SerializeField]
    private int numero_pes;
    [SerializeField]
    private int numero_maos;
    [SerializeField]
    private string arma;
    
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string NomeDoPersonagen()
    {
        return this.nome;
    }

    public void SetVitalidade(int vitalidade)
    {
        this.vitalidade = vitalidade;
    }

    public int VidaDoPersonagen()
    {
        return this.vitalidade;
    }

    public void SetPulo(int forca_pulo)
    {
        this.forca_pulo = forca_pulo;
    }

    public int PuloDoPersonagen()
    {
        return this.forca_pulo;
    }

    public void SetAttack(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int AtaqueDoPersonagen()
    {
        return this.forca_ataque;
    }

    public void SetVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public int VelocidadeDoPersonagen()
    {
        return this.velocidade;
    }

    public void SetPes(int numero_pes)
    {
        this.numero_pes = numero_pes;
    }

    public int PesDoPersonagen()
    {
        return this.numero_pes;
    }

    public void SetMaos(int numero_maos)
    {
        this.numero_maos = numero_maos;
    }

    public int MaoDoPersonagen()
    {
        return this.numero_maos;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

   

}
