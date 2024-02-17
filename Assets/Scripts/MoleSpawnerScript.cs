using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawnerScript : MonoBehaviour
{
    [SerializeField] private MoleScript molePrefab;
    [SerializeField] private RectTransform playArea;

    private float randomXPos;
    private float randomYPos;



    private void Start()
    {
        SpawnMole();
    }



    //SpawnMole called from Score Manager OnEvery10Point Event
    public void SpawnMole()
    {
        randomXPos = Random.Range(1, playArea.rect.width);
        randomYPos = Random.Range(1, playArea.rect.height);

        
        MoleScript tmpMole = Instantiate(molePrefab,transform);
        tmpMole.transform.position = new Vector3(randomXPos, randomYPos, 0);

    }

}
