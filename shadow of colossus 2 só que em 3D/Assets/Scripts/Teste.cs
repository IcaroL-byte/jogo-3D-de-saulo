using UnityEngine;

public class Teste : MonoBehaviour
{
    private NewMonoBehaviourScript fusca = new NewMonoBehaviourScript();
    private RabaRamit raba = new RabaRamit();
    
    
    void Start()
    {
       /*
        fusca.MudarNome("Fusca legal");
        fusca.AtribuirCor("Azul");
        fusca.AtribuirNumeroDeRodas(7);
        fusca.AtribuirPreço(70000f);
        
        Debug.Log("The " + fusca.NomeDoCarro());
        Debug.Log("É " + fusca.CorDoCarro());
        Debug.Log("Tem o seguinte numero de Rodas: " + fusca.NumeroDeRodas());
        Debug.Log("Custa: " + fusca.PrecoDoCarro());
    */
    
       
       raba.SetNome("Raba Ramit");
       raba.SetVitalidade(7);
       raba.SetAttack(99);
       raba.SetPulo(7);
       raba.SetVelocidade(60);
       raba.SetPes(4);
       raba.SetMaos(2);
       
       
        Debug.Log("your name is " + raba.NomeDoPersonagen() + " tá com vitalidade em " + raba.VidaDoPersonagen() + " e seu ataque tem " + raba.AtaqueDoPersonagen() + " de forca");
       Debug.Log("a forca do pulo é " + raba.PuloDoPersonagen() + " e ele anda " + raba.VelocidadeDoPersonagen() + " metros por segundo");
       Debug.Log("ele tem " + raba.PesDoPersonagen() + " pes " + raba.MaoDoPersonagen() + " maos");
        
    }

    
    void Update()
    {
        
    }
}
