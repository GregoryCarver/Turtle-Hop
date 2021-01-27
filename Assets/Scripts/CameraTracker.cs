using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script keeps the camera tracking the player on the x axis. Since the skybox is attached to the camera, it too 
//moves with the player. 
public class CameraTracker : MonoBehaviour {

    public GameObject turtle;
    float offset;

    private void Start()
    {
        offset = this.transform.position.x - turtle.transform.position.x;
    }
    // Update is called once per frame
    void Update ()
    {
        this.transform.position = new Vector3(turtle.transform.position.x + offset, 0, -10);
	}
}
