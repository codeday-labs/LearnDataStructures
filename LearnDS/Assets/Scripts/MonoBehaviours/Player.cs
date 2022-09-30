using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Player : Character
{
    public Inventory inventoryPrefab;
    public Inventory inventory;
    public TicketInventory ticketInventoryPrefab;
    public TicketInventory ticket;
    public StoveInventory stoveInventory;
    TicketClass OrderOne = new TicketClass("Breakfast Burrito", "Onion", "Garlic", "Eggs", "Sausage", "Tortilla");

    int orderIndex = 0; 
    public int itemCount; 


    public void Start()
	{
        inventory = Instantiate(inventoryPrefab);
       
        ticket = Instantiate(ticketInventoryPrefab); 
	}
    
    public void Update()
    {



        CheckStoveAndTicket();
       
         


    }
    //Player collides with Consumable Item
    void OnTriggerEnter2D(Collider2D collision)
    {
        PickUpGroundItem(collision);
        
    }


    public void PickUpGroundItem(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("CanBePickedUp"))
        {
            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;

            if (hitObject != null)
            {
                bool shouldDisappear = false;

                switch (hitObject.itemType)
                {
                     
                    case Item.ItemType.FOODITEM:
                        Debug.Log("hit FOODITEM");
                        shouldDisappear = inventory.AddItem(hitObject);
                        if (shouldDisappear)
                        {
                            collision.gameObject.SetActive(false);
                        }
                        break;
                }
                
            }
        }
    }

    public Item[] PassItem()
    {
        Item[] items = inventory.GetItems();
        return items;  
    }

    //think about name
    //what is it doing? 
    //name that would explain whats going on 
    public bool CheckStoveAndTicket()
    {
        string[] ticketOrder = ticket.PassOrder(orderIndex);
        Item[] stoveItems = stoveInventory.GetItems();

        //if ticket.length == stove.length ? 
        for(int i = 0; i < ticketOrder.Length; i++)
        {
            //handle null exception
            //try catch: handle known exception
            
            Debug.Log(ticketOrder[i]+"(Clone)(Clone)" == stoveItems[i].name);
            Debug.Log(ticketOrder[i] + " : " + stoveItems[i].name.ToString());
             
        }
        return false;
    }

     





}