using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : MonoBehaviour
{
    [SerializeField] int scoreAmount = 1;

    private ScoreClass scoreClassReference;


    // Start is called before the first frame update
    void Start()
    {
        scoreClassReference = FindObjectOfType<ScoreClass>();
    }


    //UpdateScore called on Button Click Event
    public void UpdateScore()
    {
        scoreClassReference.IncreaseScore(scoreAmount);
    }

    //DestorySelf called on either Button Click Event or when OnTimerComplete event from Timer Interval componenet
    public void DestorySelf()
    {
        Destroy(this.gameObject);
    }


}
