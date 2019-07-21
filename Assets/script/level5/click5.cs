using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click5 : MonoBehaviour
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
		gmscript5.currentword += GetComponent<TextMesh>().text;
		gmscript5.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript5.lettercount+=1;
		gameObject.SetActive(false);
		gmscript5 instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript5>();
		instanceofgmscript.completeword();
		
		
	}
}
