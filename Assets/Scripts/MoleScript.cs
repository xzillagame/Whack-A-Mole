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


    public void UpdateScore()
    {
        scoreClassReference.Score += scoreAmount;
    }


    public void DestorySelf()
    {
        Destroy(this.gameObject);
    }


}
