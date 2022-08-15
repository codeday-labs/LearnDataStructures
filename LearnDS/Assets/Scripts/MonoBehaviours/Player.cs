using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

 

public class Player : Character
{
    public Inventory inventoryPrefab;
    public Inventory inventory;

    Stove stove; 

    public void Start()
	{
      
        inventory = Instantiate(inventoryPrefab);
       
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
                    case Item.ItemType.COIN:
                        shouldDisappear = inventory.AddItem(hitObject);

                        print("hit coin");
                        break;
                    case Item.ItemType.TOMATO:
                        shouldDisappear = inventory.AddItem(hitObject);

                        print("hit Tomato");
                        break;

                }
                if (shouldDisappear)
                {
                    collision.gameObject.SetActive(false);
                }
            }
        }
    }

    public Item[] PassItem()
    {
        Item[] items = inventory.GetItem();
        return items;  
    }

   public bool CheckStoveIsFull(Collider2D collision)
    {
        //get stove items
        //check if stove inventory is full
        //



        return true; 
    }
}