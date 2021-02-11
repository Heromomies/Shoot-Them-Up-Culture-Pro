using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int currentLife;

    public int maxLife = 10;

    public Slider slider;

    public GameManager gameManager;
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

    public void AddHealth(int amount)
    {
        currentLife += amount;
        SetHealth(currentLife);
    }

    private void Update()
    {
        if (gameManager.score >= 100)
        {
            AddHealth(1);
            
        }
    }
}
