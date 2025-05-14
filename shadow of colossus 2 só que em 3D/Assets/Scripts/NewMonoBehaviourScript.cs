
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class NewMonoBehaviourScript : MonoBehaviour
{
  private string nome;
  private string cor;
  private int numero_de_rodas;
  private float preco;

  public void MudarNome(string nome)
  {
      this.nome = nome;
  }

  public string NomeDoCarro()
  {
      return this.nome;
  }
  
  public void AtribuirCor(string cor)
  {
      this.cor = cor;
  }
  
  public string CorDoCarro()
  {
      return this.cor;
  }

  public void AtribuirNumeroDeRodas(int numero_de_rodas)
  {
      this.numero_de_rodas = numero_de_rodas;
  }
  
  public int NumeroDeRodas()
  {
      return this.numero_de_rodas;
  }

  public void AtribuirPreço(float preco)
  {
      this.preco = preco;
  }
  
  public float PrecoDoCarro()
  {
      return this.preco;
  }

 
}
