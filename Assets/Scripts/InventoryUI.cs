using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform slotParent; // Reference to the parent transform of the slots
    public GameObject slotPrefab; // Reference to the slot prefab

    private Inventory inventory; // Reference to the inventory component

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        inventory.onInventoryChanged += UpdateUI; // Subscribe to the inventory change event
        UpdateUI();
    }

    // Update the UI to reflect the inventory
    void UpdateUI()
    {
        // Remove all existing slots
        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }

        // Create slots for each item in the inventory
        for (int i = 0; i < inventory.items.Count; i++)
        {
            GameObject slot = Instantiate(slotPrefab, slotParent);
            ItemSlot itemSlot = slot.GetComponent<ItemSlot>();

            // Add the item to the slot
            itemSlot.AddItem(inventory.items[i]);
        }
    }
}