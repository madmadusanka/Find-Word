using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backscript : MonoBehaviour
{
 void OnMouseDown()
 {
	 SceneManager.LoadScene ("Start", LoadSceneMode.Single);
 }
}
