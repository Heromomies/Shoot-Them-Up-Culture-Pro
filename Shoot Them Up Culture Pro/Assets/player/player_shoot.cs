using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shoot : MonoBehaviour
{
    private poolManager _poolManager;
    public Transform shootpoint;
    // Start is called before the first frame update
    void Start()
    {
        _poolManager = poolManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hello");
            _poolManager.SpawnFromPool("Bullet", shootpoint.position, Quaternion.identity);

        }
    }
}
