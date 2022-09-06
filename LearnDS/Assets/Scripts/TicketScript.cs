using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TicketScript : MonoBehaviour
{
     

    public TicketInventory ticketInventoryPrefab; 
    public TicketInventory ticketInventory;

    void Start()
    {
        TicketInventory ticketInventory = Instantiate(ticketInventoryPrefab); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
   


}
