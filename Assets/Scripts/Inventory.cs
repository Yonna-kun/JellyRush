using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int slots = 10; // Number of inventory slots
    public List<Item> items = new List<Item>(); // List to store items

    // Event to notify when the inventory changes
    public delegate void OnInventoryChanged();
    public OnInventoryChanged onInventoryChanged;

    // Add an item to the inventory
    public bool AddItem(Item item)
    {
        if (items.Count < slots)
        {
            items.Add(item);
            onInventoryChanged?.Invoke(); // Notify listeners about the inventory change
            return true;
        }

        Debug.Log("Inventory is full!");
        return false;
    }

    // Remove an item from the inventory
    public void RemoveItem(Item item)
    {
        items.Remove(item);
        onInventoryChanged?.Invoke(); // Notify listeners about the inventory change
    }
}