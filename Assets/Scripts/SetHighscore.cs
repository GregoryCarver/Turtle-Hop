﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHighscore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Text>().text = GlobalVariables.highScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
