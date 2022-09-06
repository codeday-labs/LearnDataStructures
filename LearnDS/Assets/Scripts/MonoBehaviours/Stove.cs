using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class Stove : Character
{

    public StoveInventory inventoryPrefab;
    public StoveInventory inventory;
    int ItemsIntInventory = 0;

    void Start()
    {
        inventory = Instantiate(inventoryPrefab); 
    }



    void Update()
    {
       
    }

 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        RecievePlayerItems(collision); 
    }



    public void RecievePlayerItems(Collider2D collision)
    {
        //Debug.Log("Player hit me");
        Player player = collision.gameObject.GetComponent<Player>();
        Item[] items = player.PassItem();
         
       
            if (items[0] != null)
            {
            inventory.AddItem(items[0]);
                ItemsIntInventory++; 
                player.inventory.RemoveItem();
            }
        
        Debug.Log(ItemsIntInventory); 
        if(ItemsIntInventory == 5)
        {
            player.stoveInventory = inventory;
            //Players stove inventory full after last item added
            //Debug.Log(player.CheckStoveInventory()); 
        }
    }


    public Item[] PassItem()
    {
        Item[] items = inventory.GetItems();
        return items;
    }

}
