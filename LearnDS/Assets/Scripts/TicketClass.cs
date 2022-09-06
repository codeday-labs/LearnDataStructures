using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketClass 
{
    public string dishName;
    public string firstIngredient;
    public string secondIndgredient;
    public string thirdIngredient;
    public string forthIngredient;
    public string fifthIngredient;

         //TicketClass Constructor
    public TicketClass(string dishName, string firstIngredient, string secondIndgredient, string thirdIngredient, string forthIngredient, string fifthIngredient)
    {
        this.dishName = dishName;
        this.firstIngredient = firstIngredient;
        this.secondIndgredient = secondIndgredient;
        this.thirdIngredient = thirdIngredient;
        this.forthIngredient = forthIngredient;
        this.fifthIngredient = fifthIngredient;
    }

    public string getDishName()
    {
        return dishName; 
    }

    public string GetFirstIngredient()
    {
        return firstIngredient;
    }

    public string GetSecondIngredient()
    {
        return secondIndgredient;
    }

    public string GetThirdIngredient()
    {
        return thirdIngredient;
    }

    public string GetForthIngredient()
    {
        return forthIngredient;
    }

    public string GetFifthIngredient()
    {
        return fifthIngredient;
    }

    public string[] GetIngredientsArray()
    {
        string[] ingArray = {   firstIngredient,  secondIndgredient,  thirdIngredient,  forthIngredient,  fifthIngredient };


        return ingArray; 
    }

    




}