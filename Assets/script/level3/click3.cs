using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click3 : MonoBehaviour
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
		gmscript3.currentword += GetComponent<TextMesh>().text;
		gmscript3.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript3.lettercount+=1;
		gameObject.SetActive(false);
		gmscript3 instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript3>();
		instanceofgmscript.completeword();
		
		
	}
}
