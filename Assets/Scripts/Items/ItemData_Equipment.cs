using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Weapon,
    Armor,
    Shield,
    Consumable,
}

[CreateAssetMenu(fileName = "New Equipment Item", menuName = "Data/Equipment")]

public class ItemData_Equipment : ItemData
{
    public EquipmentType equipmentType;
    public ItemEffect[] effects;	

    [Header("Major stats")]
    public int health;
    public int mana;
    public int stamina;


    [Header("Offensive stats")]

    public int damage;
    public int attackSpeed;
    public int critChance;


    [Header("Craft requirements")]
    public List<InventoryItem> craftingMaterials;

    public void ItemEffect()
    {
        foreach (ItemEffect effect in effects)
        {
            effect.ExecuteItemEffect();
        }
    }

    public void AddModifiers()
    {
        // Aqui es donde se tiene que settear las stats segun lo que reciba del item en cuestion dentro de las DATAS 
    }

    public void RemoveModifiers()
    {
        // Aqui es donde se tiene que remover las stats segun lo que reciba del item en cuestion dentro de las DATAS
    }


}
