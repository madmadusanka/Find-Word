using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnMouseDown()

	{
		gmscript4.currentword += GetComponent<TextMesh>().text;
		gmscript4.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript4.lettercount+=1;
		gameObject.SetActive(false);
		gmscript4 instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript4>();
		instanceofgmscript.completeword();
		
		
	}
}
