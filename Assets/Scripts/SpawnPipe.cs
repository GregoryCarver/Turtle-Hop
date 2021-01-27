using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script spawns the next pipe when the player lands on the pipe. 
public class SpawnPipe : MonoBehaviour
{
    bool hasSpawned;

    private void OnTriggerEnter2D()
    {
        if(!hasSpawned)
        {
            float spawnDistance;

            spawnDistance = Random.Range(1.5f, 4.7f);

            Instantiate(this,
                        new Vector3(this.transform.position.x + spawnDistance, this.transform.position.y),
                        new Quaternion());

            hasSpawned = true;
        }
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
