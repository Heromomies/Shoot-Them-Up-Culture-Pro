using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI lifeTxt;
    private int _score;
    private int _life;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateScore(int scoreToAdd)
    {
        _score += scoreToAdd;
        scoreTxt.text = $"Score : {_score}";
    }

    public void UpdateLife(int lifeToAdd)
    {
        _life += lifeToAdd;
        lifeTxt.text = $"Life : {_life}";
    }
}
