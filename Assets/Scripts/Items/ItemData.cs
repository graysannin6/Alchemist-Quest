using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipment,
    Material,
    
}

[CreateAssetMenu(fileName = "new ItemData", menuName = "Data/Item")]
public class ItemData : ScriptableObject
{   
    public ItemType itemType;
    public string itemName;
    public Sprite icon;
}
