using UnityEngine;
using UnityEngine.Events;

public class InteractHavingItem : MonoBehaviour, IClickeable
{
    public ItemSO neededItem;
    public bool isConsumed;
    public UnityEvent onSucessInteract;
    public UnityEvent onFailureInteract;
    public void OnClick()
    {
        if(InventoryManager.instance.GetItemSO(neededItem) != null)
        {
            onSucessInteract?.Invoke();
            if(isConsumed)
            {
                InventoryManager.instance.RemoveItem(neededItem);
            }
        }
        else
        {
            onFailureInteract?.Invoke();
        }
    }
}
