﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI lifeTxt;

    public int score;

    private int _life;

    public GameObject panelGameOver;
    public GameObject panelPause;
    public GameObject player;
    public GameObject boss;

    private bool _isPause;
    public static GameManager instance;

    private void Awake()
    {
        Time.timeScale = 1;
        instance = this;
    }

    private void Update()
    {
        _life = player.GetComponent<PlayerLife>().currentLife;
        if (_life <= 0)
        {
            Time.timeScale = 0;
            panelGameOver.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && _life > 0 && !_isPause)
        {
            _isPause = true;
            Time.timeScale = 0;
            panelPause.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _life > 0 && _isPause)
        {
            _isPause = false;
            Time.timeScale = 1;
            panelPause.SetActive(false);
        }

        if (score >= 100)
        {
            boss.SetActive(true);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreTxt.text = $"Score : {score}";
    }

    public void UpdateLife(int lifeToAdd)
    {
        _life += lifeToAdd;
        lifeTxt.text = $"Life : {_life}";
    }
}