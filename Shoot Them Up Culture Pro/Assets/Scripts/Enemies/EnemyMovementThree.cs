using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementThree : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;
    
    private Transform _target;
    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, _target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
        }
    }
}
