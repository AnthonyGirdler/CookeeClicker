using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform parentObject;


    private void Start()
    {
        /* for(int i=0; i<100; i++)
         {
             SpawnObject();
         }
        */

        int count = 0;
        while (count < 0)
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
    }

    



}
