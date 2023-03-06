using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform parentObject;
    public TMP_Text beeCountText;
    public TMP_Text multiplierText;


    public int beeCount = 0;
    public int beeMultiplier = 1;


    private void Start()
    {
       
    }

    public void IncreaseBeeMultiplier(int increaseBy)
    {
        beeMultiplier += increaseBy;

        if (beeMultiplier != null)
        {
            multiplierText.text = beeMultiplier.ToString();
        }
    }
    public void SpawnMultipleObjects()
    {
        int count = 0;
        while (count < beeMultiplier)
        {
            count += 1;
            SpawnObject();
        }
    }


    public void SpawnObject()
    {
        Instantiate(spawnPrefab,
            parentObject.position,
            parentObject.rotation,
            parentObject
            );
        

        beeCount++;

        if(beeCount != null)
        {
            beeCountText.text = beeCount.ToString();
        }

        
    }

    
    
    



}
