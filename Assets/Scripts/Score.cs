using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    void Start()
    {
        GameManager.IncreaseScoreEvent += UpdateScoreText;
    }

    void UpdateScoreText()
    {
        scoreText.text = GameManager.Score.ToString();
    }
}
