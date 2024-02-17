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

    //Event after every 10 Points is recieved
    [Serializable]
    public class Every10ScorePoints : UnityEvent { }
    public Every10ScorePoints onEvery10PointsRecieved;



    private int score;
    private int Score
    {
        get
        {
            return score;
        }

        set 
        {
            score = value;

            //Check if Score reaches every 10 points. If so invoke onEvery10PointsRecieved event
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


    //Called from Button event OnClick
    public void IncreaseScore(int inputScore)
    {
        Score += inputScore;
    }

    
    //Update text field with the current score
    private void UpdateDisplayScore()
    {
        scoreDisplay.text = "Score: " + Score;
    }


}
