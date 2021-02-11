using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int life;

    public float speed, repeatRate;
    public Transform yMax, shootPoint;
    public GameObject panel; 
    
    private Vector2 _screenBounds;
    private bool _dirRight;
    private poolManager _poolManager;

    public TextMeshProUGUI scoreFinal;
    public void Start()
    {
        _poolManager = poolManager.instance;
        InvokeRepeating("LaunchBullet", 0, repeatRate);
    }

    public void LaunchBullet()
    {
        _poolManager.SpawnFromPool("BulletBoss", shootPoint.position, Quaternion.identity);
    }
    void Update()
    {
        if (transform.position.y >= yMax.position.y)
        {
           Down();
        }
        else
        {
            InvokeBoss();
        }
    }
    void InvokeBoss()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if (_dirRight)
        {
            transform.Translate(Vector2.right * (speed * Time.deltaTime));
        }
        else
        {
            transform.Translate(Vector2.left * (speed * Time.deltaTime));
        }
        if (transform.position.x >= _screenBounds.x)
        {
            _dirRight = false;
        }
        if (transform.position.x <= _screenBounds.x * -1)
        {
            _dirRight = true;
        }
    }
    void Down()
    {
        transform.Translate(Vector2.down * (Time.deltaTime * speed));
    }
    public void Damage(int amount)
    {
        life -= amount;
        if (life <= 0)
        {
            panel.SetActive(true);
            gameObject.SetActive(false);
            scoreFinal.text = GameManager.instance.score.ToString();
        }
    }
}
