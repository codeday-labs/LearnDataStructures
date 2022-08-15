using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
  

    [HideInInspector]
    public Character character;

    public Image meterImage;

    public Text hpText;

    public float maxHitPoints;

    void Start()
    {
      
    }

    void Update()
    {
        if (character != null)
        {
           
        }
    }
}
