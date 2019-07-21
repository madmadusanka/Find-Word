using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click6 : MonoBehaviour
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
		gmscript6.currentword += GetComponent<TextMesh>().text;
		gmscript6.currentletter=GetComponent<TextMesh>().text;
		//Debug.Log (gmscript.currentword);
		gmscript6.lettercount+=1;
		gameObject.SetActive(false);
		gmscript6 instanceofgmscript=GameObject.Find("gm").GetComponent<gmscript6>();
		instanceofgmscript.completeword();
		
		
	}
}
