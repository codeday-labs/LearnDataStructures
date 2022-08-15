using UnityEngine;

public abstract class Character : MonoBehaviour {

    public enum CharacterCategory
    {
        PLAYER, 
        STOVE
    }

    public CharacterCategory characterCategory;
}
