using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        Time.timeScale = 1;
        GameManager.instance.panelPause.SetActive(false);
    }

    public void Rstart()
    {
        SceneManager.LoadScene(0);
    }
}
