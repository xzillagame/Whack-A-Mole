using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using System;
using UnityEngine.Events;

public class ScoreClass : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreDisplay;

    [Serializable]
    public class Every10ScorePoints : UnityEvent { }
    public Every10ScorePoints onEvery10PointsRecieved;



    private int score;
    public int Score
    {
        get
        {
            return score;
        }

        set 
        {
            score = value;

            if(score % 10 == 0)
            {
                onEvery10PointsRecieved.Invoke();
            }

            UpdateDisplayScore();
        }  

    }


    private void Start()
    {
        UpdateDisplayScore();
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            IncreaseScore(1);
        }

    }

    public void IncreaseScore(int inputScore)
    {
        Score += inputScore;
    }

    private void UpdateDisplayScore()
    {
        scoreDisplay.text = "Score: " + Score;
    }


}
