using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCloud : MonoBehaviour {

    bool hasSpawned;
    public GameObject turtle;
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasSpawned && turtle.transform.position.x > this.transform.position.x - 11.0f)
        {
            float spawnDistance;
            float spawnHeight;

            spawnDistance = Random.Range(2.0f, 4.0f);
            spawnHeight = Random.Range(-0.75f, 4.0f);

            Instantiate(this,
                        new Vector3(this.transform.position.x + spawnDistance, spawnHeight),
                        new Quaternion());

            hasSpawned = true;
        }
    }
}
