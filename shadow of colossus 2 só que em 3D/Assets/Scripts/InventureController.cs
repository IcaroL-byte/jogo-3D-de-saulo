using UnityEngine;
using UnityEngine.UI;

public class InventureController : MonoBehaviour
{
    public Objecta[] slots;
    public Image[] slotImage;
    public int[] slotAmount;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        interacao();

    }

    void interacao()
    {
        if (Input.GetMouseButtonDown(0)) // clique com o botão esquerdo
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("Clicou em: " + hit.transform.name);

                // Se quiser interagir com objeto específico
                if (hit.transform.CompareTag("Interagivel"))
                {
                    for (int i = 0; i < slots.Length; i++)
                    {
                        if (slots[i] == null || slots[i].name == hit.transform.GetComponent<ObjectType>().objectType.name)
                        {
                            slots[i] = hit.transform.GetComponent<ObjectType>().objectType;
                            slotAmount[i]++;
                            slotImage[i].sprite = slots[i].itemSprite;

                            Destroy(hit.transform.gameObject);
                            break;
                        }
                    }
                    
                }
            }
        }
    }

}
