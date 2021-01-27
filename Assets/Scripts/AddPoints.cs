using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPoints : MonoBehaviour {

    bool pointRewarded;
    public AudioSource coinSound;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!pointRewarded)
        {
            GlobalVariables.points++;
            coinSound.Play();
            pointRewarded = true;
            GameObject.FindGameObjectWithTag("Points").GetComponent<Text>().text = GlobalVariables.points.ToString();
        }
    }
    // Update is called once per frame
    void Update ()
    {
		
	}
}
