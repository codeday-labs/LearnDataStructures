using UnityEngine;
 

public class Player : Character
{
    public Inventory inventoryPrefab;
    Inventory inventory;

    

    public void Start()
	{
      
        inventory = Instantiate(inventoryPrefab);
       
	}

	void OnTriggerEnter2D(Collider2D collision)
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
                   
                }

                if (shouldDisappear)
                {
                    collision.gameObject.SetActive(false);
                }
            }
        }
    }

  
}