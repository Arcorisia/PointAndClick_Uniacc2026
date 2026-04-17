using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<ItemSO> inventory;
    public Slot slot;
    public Transform slotContainer;

    void Awake()
    {
        instance = this;
        RefreshUI();
    }

    public void AddItem(ItemSO itemSO)
    {
        inventory.Add(itemSO);
        RefreshUI();
    }
    public void RemoveItem(ItemSO itemSO)
    {
        inventory.Remove(itemSO);
        RefreshUI();
    }
    public ItemSO GetItemSO(ItemSO itemSO)
    {
        foreach(var item in inventory)
        {
            if(item == itemSO)
            {
                return item;
            }
        }
        return null;
    }
    public void RefreshUI()
    {
        foreach(Transform t in slotContainer)
        {
            Destroy(t.gameObject);
        }
        foreach(var item in inventory)
        {
            Slot s = Instantiate(slot, slotContainer);
            s.SetInfo(item);
        }
    }
    
}
