﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scene1click : MonoBehaviour
{
	int levels;
    // Start is called before the first frame update
    void Start()
    {
        levels=PlayerPrefs.GetInt("currentLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
		public void newgame()
		{
			PlayerPrefs.SetInt("currentLevel", 1);
			PlayerPrefs.SetInt("score",0);
			SceneManager.LoadScene (1, LoadSceneMode.Single);

			
		}
		 public void Continue()
		{	
			SceneManager.LoadScene (levels, LoadSceneMode.Single);
			
		}
}