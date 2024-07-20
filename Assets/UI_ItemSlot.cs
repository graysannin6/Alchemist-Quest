using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UI_ItemSlot : MonoBehaviour
{   
    [SerializeField]private Image itemImage;
    [SerializeField]private TextMeshProUGUI itemText;

    public InventoryItem item;

    // Start is called before the first frame update
    public void UpdateSlotUI(InventoryItem _newItem)
    {
        if (item != null)
        {
            itemImage.sprite = item.data.icon;

            if (item.stackSize > 1)
            {
                itemText.text = item.stackSize.ToString();
            }
            else
            {
                itemText.text = "";
            }
        }
    }
}
