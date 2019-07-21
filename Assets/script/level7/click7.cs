using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click7 : MonoBehaviour
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
		gmscript7.currentword += GetComponent<TextMesh>().text;
		gmscript7.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript7.lettercount+=1;
		gameObject.SetActive(false);
		gmscript7 instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript7>();
		instanceofgmscript.completeword();
		
		
	}
}
