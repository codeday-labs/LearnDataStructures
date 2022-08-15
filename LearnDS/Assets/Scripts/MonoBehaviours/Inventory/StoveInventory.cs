using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class StoveInventory : MonoBehaviour
{
    public GameObject slotPrefab;

    public const int numSlots = 5;

    public Image[] itemImages = new Image[numSlots]; 
    public Item[] items = new Item[numSlots];
    public GameObject[] slots = new GameObject[numSlots];

    public void Start()
    {
        CreateSlots();

    }

    public void CreateSlots()
    {
        if (slotPrefab != null)
        {
            for (int i = 0; i < numSlots; i++)
            {
                GameObject newSlot = Instantiate(slotPrefab);
                newSlot.name = "ItemSlot_" + i;
                newSlot.transform.SetParent(gameObject.transform.GetChild(0).transform);
                slots[i] = newSlot;
                itemImages[i] = newSlot.transform.GetChild(1).GetComponent<Image>();
            }
        }
    }

    public bool AddItem(Item itemToAdd)
    {
        Debug.Log("item to add " + itemToAdd.name); 
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

    public void GetItems()
    {
        int count = 0; 
        while (items[count] != null)
        {
            Debug.Log("item in inventory " + items[count]);
            count++; 
        }
    }

}