using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementTwo : MonoBehaviour
{
    public float speed;

    public float frequency, magnitude;

    private Vector3 _pos;
    
    // Update is called once per frame
    void Update()
    {
        _pos -= transform.up * (Time.deltaTime * speed);
        transform.position = _pos + transform.right * (Mathf.Cos(Time.time * frequency) * magnitude);
    }
}
