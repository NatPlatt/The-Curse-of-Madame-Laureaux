using UnityEngine;

public class InventoryOpen : MonoBehaviour
{
    public static bool InventoryIsUp = false;
    public bool inventoryIsOpen = false;

    public GameObject inventoryMenuUI;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryIsUp)
            {
                CloseInventory();
            }
            else
            {
                OpenInventory();
            }
        }
    }
}
