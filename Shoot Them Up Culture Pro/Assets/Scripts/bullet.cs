using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * (speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<EnemyLife>())
        {
            other.gameObject.GetComponent<EnemyLife>().Damage(1);
            gameObject.SetActive(false);
        }

        if (other.gameObject.GetComponent<Boss>())
        {
            other.gameObject.GetComponent<Boss>().Damage(1);
            gameObject.SetActive(false);
        }
    }
}
