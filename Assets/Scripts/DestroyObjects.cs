using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script destroys the objects they are off screen.
public class DestroyObjects : MonoBehaviour
{
    public GameObject turtle;

	// Update is called once per frame
	void Update ()
    {
		if(turtle.transform.position.x >= this.transform.position.x + 17)
        {
            Destroy(this.gameObject);
        }
	}
}
