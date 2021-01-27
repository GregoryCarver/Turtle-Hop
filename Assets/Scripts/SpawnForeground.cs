using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script spawns the foreground depending on where the player is. 
public class SpawnForeground : MonoBehaviour
{
    bool hasSpawned;
    public GameObject turtle;
    float xPos;
    float yPos;

	// Use this for initialization
	void Start ()
    {
        hasSpawned = false;
        xPos = this.transform.position.x;
        yPos = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(turtle.transform.position.x > xPos - 11 && hasSpawned == false)
        {
            Instantiate(this, new Vector3(xPos + 6.36f, yPos), new Quaternion());
            hasSpawned = true;
        }
	}
}
