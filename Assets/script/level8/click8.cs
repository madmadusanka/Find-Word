using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click8 : MonoBehaviour
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
		gmscript8.currentword += GetComponent<TextMesh>().text;
		gmscript8.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript8.lettercount+=1;
		gameObject.SetActive(false);
		gmscript8 instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript8>();
		instanceofgmscript.completeword();
		
		
	}
}
