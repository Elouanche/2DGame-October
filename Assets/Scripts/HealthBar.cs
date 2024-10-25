using UnityEngine;
using UnityEngine.UI; //tout ce qui concerne l'UI on le retrouve grace à ça 

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health; 
    }

    public void SetHealth(int health)
    {
        slider.value = health;

    }
}
