using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public RabaRamit personagem;
        private int ataque;

    public GameObject inventoryPanel;
    private bool activeInventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activeInventory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
        if (activeInventory)
        {
            Cursor.lockState = CursorLockMode.None;
        }


    }

    public int AtaqueDoPersonagem()
    {
        ataque = personagem.AtaqueDoPersonagen(); 
        return ataque;
    }
}
