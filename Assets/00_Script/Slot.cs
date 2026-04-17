using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public ItemSO itemSO;
    public Image itemIcon;

    public void SetInfo(ItemSO item)
    {
        itemSO = item;
        itemIcon.sprite = item.itemIcon;
    }
}
