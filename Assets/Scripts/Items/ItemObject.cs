using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{   
    private SpriteRenderer sr;
    [SerializeField] private ItemData itemData;

    public void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = itemData.icon;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if(collision.GetComponent<Player>() != null)
        {
            Debug.Log("Player picked up " + itemData.itemName);
            Destroy(gameObject);
        }*/
    }    
}