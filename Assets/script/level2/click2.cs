using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click2 : MonoBehaviour
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
		gmscript2.currentword += GetComponent<TextMesh>().text;
		gmscript2.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript2.lettercount+=1;
		gameObject.SetActive(false);
		gmscript2 instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript2>();
		instanceofgmscript.completeword();
		
		
	}
}
