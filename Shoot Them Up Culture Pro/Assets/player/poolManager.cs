using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolManager : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionnary;

    public static poolManager instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        poolDictionnary = new Dictionary<string, Queue<GameObject>>();


        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();


            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }


            poolDictionnary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionnary.ContainsKey(tag))
        {
            return null;
        }


        GameObject objectToSpawn = poolDictionnary[tag].Dequeue();


        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictionnary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}