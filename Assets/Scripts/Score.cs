using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class ScoreClass : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreDisplay;


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
