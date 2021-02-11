using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
{
    public float speed;
   
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * (speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<PlayerLife>())
        {
            other.gameObject.GetComponent<PlayerLife>().TakeDamage(1);
        }
    }
}
