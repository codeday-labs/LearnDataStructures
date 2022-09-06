using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TicketInventory : InventoryAbstract
{
    public static int numSlots = 5;

    public Text[] TicketIngredients = new Text[numSlots];
    public Text[] ticketItems = new Text[numSlots];
    public GameObject[] slots = new GameObject[5];
  
    List<TicketClass> OrderList = new List<TicketClass>();
    /* TicketClass OrderOne =  new TicketClass("Breakfast Burrito", "Onion", "Garlic", "Eggs", "Sausage", "Tortilla");
    */
    int orderIndex = 0;


   


    public override void CreateSlots()
    {
        setTicketOrder();
        
        string[] ingredientsArray = OrderList[orderIndex].GetIngredientsArray();
        


        if (slotPrefab != null)
        {
            for (int i = 0; i<numSlots; i++)
            {
             
                GameObject newSlot = Instantiate(slotPrefab);
                newSlot.SetActive(true);
                newSlot.GetComponentInChildren<Text>().text = ingredientsArray[i]; 
                newSlot.name = "Ingredient" + i;
                newSlot.transform.SetParent(gameObject.transform.GetChild(0).transform, false);
               
            }
        }
    }


    public string[] PassOrder(int num)
    {
        return OrderList[num].GetIngredientsArray();
    }

    public void setTicketOrder()
    {
        OrderList.Add(new TicketClass("Burger", "Bread", "Onion", "Tomato", "Beef", "Bread"));
        OrderList.Add(new TicketClass("Pickle Sandwhich", "Bread", "Cheese", "Ham", "Pickle", "Bread")); 
    }

    public void setOrderIndex(int num)
    {
        this.orderIndex = num; 
    }

    public int getOrderIndex()
    {
        return orderIndex;
    }

}
