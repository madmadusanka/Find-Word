using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
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
		gmscript.currentword += GetComponent<TextMesh>().text;
		gmscript.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript.lettercount+=1;
		gameObject.SetActive(false);
		gmscript instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript>();
		instanceofgmscript.completeword();	
	}
}
