using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 5;

    public GameObject spawnPrefab;
    public Transform parentObject;

    private void OnCollisionEnter2D(Collision2D col)
    {
              
        /*if(col.gameObject.GetComponent<Health>() == null)//the object it's colliding with has health, so don't die.

        {
            health--;

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }*/

        if(col.gameObject.tag == "blade")
            {
            health--;

            if (health <= 0)
            {
                Destroy(gameObject);
                Instantiate(spawnPrefab,
            parentObject.position,
            parentObject.rotation,
            parentObject
            );
            }
        }

       
    }

}
