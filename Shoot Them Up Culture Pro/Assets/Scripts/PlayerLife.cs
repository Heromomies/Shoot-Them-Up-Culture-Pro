using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int currentLife;

    public int maxLife = 10;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
        SetMaxHealth(maxLife);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void TakeDamage(int amount)
    {
        currentLife -= amount;
        SetHealth(currentLife);
    }
}
