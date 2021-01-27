using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GlobalVariables.highScore = PlayerPrefs.GetInt("HighScore");
    }
}
