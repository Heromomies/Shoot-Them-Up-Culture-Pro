using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
   

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * (speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<EnemyLife>())
        {
            Debug.Log("ui");
            other.gameObject.GetComponent<EnemyLife>().Damage(1);
        }
    }
}
