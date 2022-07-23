using UnityEngine;

public abstract class Character : MonoBehaviour {

    

 

    public enum CharacterCategory
    {
        PLAYER,
        ENEMY
    }

    public CharacterCategory characterCategory;
}
