using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solutionManager : MonoBehaviour
{
	List<string> minimalPairs = new List<string>(new string[] { 
		"posa", "fosa", "pajar", "fajar", "peco", "feco", "puma", "fuma", "piar", "fiar", "sopa", "soba", "pesar", "besar", "pus", "bus", "pastar", "bastar",
		 "porra", "borra", "pilla", "billa", "ropa", "roma", /*"par", "mar",*/ "pino", "mino", "mapa", "mama", "pesa", "mesa", "pasa", "masa", "peco", "weco",
		  "peso", "weso", "pida", "wida", "pesa", "wesa", "peca", "weca", "pero", "wero", "casa", "masa", "cara", "para", "beso", "peso", "trabajo", "trabaja"});//,
		   //"quien", "bien", "fabrique", "fabrico", "pera", "para", "canto", "canta", "digo", "diga", "pisar", "pesar", "suerte", "muerte", "gordo", "gorda", "queso",
		    //"caso", "beso", "besa", "coro", "caro", "fuerte", "suerte"});

	int cnt = 52;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newPair(){
    	Debug.Log(minimalPairs.Count);
    	int rand = Random.Range(0,cnt/2);
    	GameObject temp = GameObject.Find("Canvas");
    	temp.GetComponent<enableButtons>().t1 = minimalPairs[(rand*2)];
    	temp.GetComponent<enableButtons>().t2 = minimalPairs[(rand*2)+1];
    	int solnRand = Random.Range(0,2);
    	if(solnRand == 0)
    		GetComponent<clickController>().isLeftSoln = true;    		
    	else
    		GetComponent<clickController>().isLeftSoln = false;
    	//For upto 23
    	if(rand<=11){
    		if(rand<=4)
    			GameObject.Find("Audio Source").GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("_0" + (rand*2+solnRand).ToString());
    		else
    			GameObject.Find("Audio Source").GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("_" + (rand*2+solnRand).ToString());
    	}
    	else
    		GameObject.Find("Audio Source").GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("_" + (rand*2+solnRand+1).ToString());

    	Debug.Log("_0" + (rand*2+solnRand).ToString()+".wav");
    	
    }
}
