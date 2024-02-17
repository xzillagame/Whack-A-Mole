using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawnerScript : MonoBehaviour
{
    [SerializeField] private MoleScript molePrefab;
    [SerializeField] private RectTransform playArea;

    private float randomX;
    private float randomY;


    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.H))
        {
            SpawnMole();
        }

    }



    void SpawnMole()
    {
        randomX = Random.Range(1, playArea.rect.width);
        randomY = Random.Range(1, playArea.rect.height);

        
        MoleScript tmpMole = Instantiate(molePrefab,transform);
        tmpMole.transform.position = new Vector3(randomX, randomY, 0);

        
    }

}
