using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int life;
    
    public void Damage(int amount)
    {
        life -= amount;
        if (life <= 0)
        {
            GameManager.instance.UpdateScore(10);
            Destroy(gameObject);
           
        }
    }
}
