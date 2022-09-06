using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class InventoryAbstract : MonoBehaviour
{

    public GameObject slotPrefab;


    public static int numSlots;
    public Image[] itemImages = new Image[numSlots];
    public Item[] items = new Item[numSlots];
    public GameObject[] slots = new GameObject[numSlots];
    

    public void Start()
    {
        CreateSlots();

    }

   

    public virtual void CreateSlots()
    {
        numSlots = 5; 

        if (slotPrefab != null)
        {
            for (int i = 0; i < numSlots; i++)
            {
                GameObject newSlot = Instantiate(slotPrefab);
                newSlot.name = "ItemSlot_" + i;
                newSlot.transform.SetParent(gameObject.transform.GetChild(0).transform);
                slots[i]=newSlot;
                itemImages[i] = newSlot.transform.GetChild(1).GetComponent<Image>();
            }
        }
    }

    public bool AddItem(Item itemToAdd)
    {
        //Debug.Log("item to add " + itemToAdd.name);
        for (int i = 0; i < items.Length; i++)
        {

            if (items[i] == null)
            {
                // Adding to empty slot
                // Copy item and add to inventory. Copying so we dont modify original Scriptable Object
                items[i] = Instantiate(itemToAdd);
                items[i].quantity = 1;
                itemImages[i].sprite = itemToAdd.sprite;
                itemImages[i].enabled = true;

                return true;
            }
        }
        return false;
    }

    public Item[] GetItems()
    {
        return items;
    }


    public void RemoveItem()
    {
        foreach (Item item in items)
        {
            if (item != null)
            {
                item.quantity = 0;
                itemImages[0].sprite = null;
                itemImages[0].enabled = false;
                items[0].quantity = 0;
                items[0] = null;


            }
        }
    }
}
