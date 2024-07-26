using System.Text;
using UnityEditor;
using UnityEditor.VersionControl;
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

    protected StringBuilder sb = new StringBuilder();

    public virtual string GetDescription()
    {
        return "";
    }
}
