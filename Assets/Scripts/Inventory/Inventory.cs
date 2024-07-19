using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<ItemData> items = new List<ItemData>();

    private void Awake()
    {
        if(instance != null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void AddItem(ItemData _item)
    {
        items.Add(_item);
    }
}
