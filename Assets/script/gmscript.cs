using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmscript : MonoBehaviour
{	
	public static string currentword;
	public static int lettercount;
	public static int level;
	public static int score;
	public static int tempscore;
	public static string currentletter;
	public Transform wordbox1;
	public Transform wordbox2;
	public Transform wordbox3;
	public Transform message;
	public Transform englishword;
	public Transform sinhalaword;
	public Transform scorebox;
	public GameObject letter1;
	public GameObject letter2;
	public GameObject letter3;
	public static string mean;
	public static int currentLevel;
	public GameObject animation5;
	public GameObject animation10;
	public GameObject congrats;
	List<string> templist = new List<string>();
	
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
		tempscore = score;
		level=1;
		
    }

    // Update is called once per frame
    void Update()
    {
	if (lettercount==1){
		wordbox1.GetComponent<TextMesh>().text=currentletter;
		message.GetComponent<TextMesh>().text=null;
	}
	else if(lettercount==2)
	{
		wordbox2.GetComponent<TextMesh>().text=currentletter;
	}
	else if(lettercount==3){
		wordbox3.GetComponent<TextMesh>().text=currentletter;
		
	}
	
    }
	 public void completeword()
    {
		if (lettercount==3)
		{
			switch(currentword)
				{case "ACT":innerlevel("A","P","T");
				
								break;
				case "APT":innerlevel("E","A","T");
						break;
				case "ATE":innerlevel("R","T","A");
						break;
				case "TAR":innerlevel("O","R","T");
						break;
				case "TOR":innerlevel("A","B","T");
						break;
				case "TAB":StartCoroutine(nextleveltimer());
						break;
				default:			
							if(!templist.Contains(currentword))
							{
								if (dictionary.dic1.ContainsKey(currentword))
								{
									message.GetComponent<TextMesh>().text="5 Points";
									//score=int.Parse(scorebox.GetComponent<TextMesh>().text);
									tempscore+=5;
									scorebox.GetComponent<TextMesh>().text="score "+tempscore;
									templist.Add(currentword);
									StartCoroutine(animation5timer());
								}
								else
								{
									message.GetComponent<TextMesh>().text="Wrong Word";
									StartCoroutine(waittime());
								}
							}
							else if(templist.Contains(currentword))
							{
								if(dictionary.dic1.ContainsKey(currentword))
								{
									message.GetComponent<TextMesh>().text="Already used";
									StartCoroutine(waittime());
								}
								else 
								{
									message.GetComponent<TextMesh>().text="Wrong Word";
									StartCoroutine(waittime());
								}
							}
							break;
				}

			
			

	
		}
    }
	  IEnumerator waittime()
    {	
        yield return new WaitForSecondsRealtime(0.4f);
		if (dictionary.dic1.ContainsKey(currentword))
		{
			sinhalaword.GetComponent<TextMesh>().text=dictionary.dic1[currentword];
			englishword.GetComponent<TextMesh>().text=currentword;
		}
		
		lettercount=0;
		currentword=null;
		letter1.SetActive(true);
		letter2.SetActive(true);
		letter3.SetActive(true);
		wordbox1.GetComponent<TextMesh>().text=null;
		wordbox2.GetComponent<TextMesh>().text=null;
		wordbox3.GetComponent<TextMesh>().text=null;

		
    }
	  IEnumerator animation5timer() 
    {	sinhalaword.GetComponent<TextMesh>().text=null;
		englishword.GetComponent<TextMesh>().text=null;
		animation5.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
		animation5.SetActive(false);
		StartCoroutine(waittime());	
    }
	 IEnumerator animation10timer()
	 
    {	sinhalaword.GetComponent<TextMesh>().text=null;
		englishword.GetComponent<TextMesh>().text=null;
		animation10.SetActive(true);
		scorebox.GetComponent<TextMesh>().text="score "+tempscore;
        yield return new WaitForSecondsRealtime(0.6f);
		animation10.SetActive(false);
		StartCoroutine(waittime());	
    }
	 IEnumerator nextleveltimer()
	 {	tempscore+=20;	
		message.GetComponent<TextMesh>().text="Condratulations ";
		scorebox.GetComponent<TextMesh>().text="score "+tempscore;
		sinhalaword.GetComponent<TextMesh>().text=dictionary.dic1[currentword];
		englishword.GetComponent<TextMesh>().text=currentword;
		score=tempscore;
		level+=1;
		PlayerPrefs.SetInt("currentLevel",1);
		PlayerPrefs.SetInt("score",score);
		congrats.SetActive(true); 
		templist.Clear();
		yield return new WaitForSecondsRealtime(5);
		//congrats.SetActive(false);
		SceneManager.LoadScene (level, LoadSceneMode.Single);
		
	 }
	 public void innerlevel(string a,string b,string c)
	 {
		tempscore+=10;			
		sinhalaword.GetComponent<TextMesh>().text=dictionary.dic1[currentword];
		englishword.GetComponent<TextMesh>().text=currentword;
		StartCoroutine(animation10timer());
		letter1.GetComponent<TextMesh>().text=a;
		letter2.GetComponent<TextMesh>().text=b;
		letter3.GetComponent<TextMesh>().text=c;
		templist.Clear(); 
	 }
	 
	
}
