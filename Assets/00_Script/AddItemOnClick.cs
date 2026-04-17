using UnityEngine;

public class AddItemOnClick : MonoBehaviour, IClickeable
{
    public ItemSO item;
    public void OnClick()
    {
        InventoryManager.instance.AddItem(item);
        Destroy(gameObject);
    }

   
}
