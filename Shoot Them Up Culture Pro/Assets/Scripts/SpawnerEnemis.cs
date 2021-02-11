using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemi",0,Random.Range(.8f,1.5f));
    }

    void SpawnEnemi()
    {
        Vector2  _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        poolManager.instance.SpawnFromPool("Enemi", new Vector2(Random.Range(_screenBounds.x*-1,_screenBounds.x),_screenBounds.y), Quaternion.identity);
    }
}
