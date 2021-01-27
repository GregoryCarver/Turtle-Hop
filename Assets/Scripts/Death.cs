using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject gameOver;
    //public GameObject ads;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
		if(this.transform.position.y < -4.5f)
        {
            this.GetComponent<PlayerMovement>().enabled = false;
            gameOver.SetActive(true);
            //ads.GetComponent<Ads>().ShowAd();
        }
	}
}
