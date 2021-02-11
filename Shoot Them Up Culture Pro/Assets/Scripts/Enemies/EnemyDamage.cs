using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<PlayerLife>())
        {
            other.gameObject.GetComponent<PlayerLife>().TakeDamage(1);
        }
    }
}
