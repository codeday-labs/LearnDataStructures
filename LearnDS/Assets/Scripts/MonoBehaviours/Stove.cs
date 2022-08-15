using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class Stove : Character
{

    public StoveInventory inventoryPrefab;
    public StoveInventory inventory;

    void Start()
    {
        inventory = Instantiate(inventoryPrefab); 
    }



    void Update()
    {
       
    }

    //On hit Trigger to transfer items from player to Inventory
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //need to add checker for when items is already in inventory
        RecievePlayerItems(collision); 
    }


    //Gets Item from player and stores in stove inventory 
    public void RecievePlayerItems(Collider2D collision)
    {
        Debug.Log("Player hit me");
        Player player = collision.gameObject.GetComponent<Player>();
        Item[] items = player.PassItem();

        foreach (Item item in items)
        {
            if (item != null)
            {
                Debug.Log("move " + item.name + " to stove");
                inventory.AddItem(item);
                player.inventory.RemoveItem();
            }
            else
            {
                Debug.Log("null item");
            }
        }

        inventory.GetItems();

    }


  

}
