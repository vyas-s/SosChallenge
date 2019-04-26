using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickController : MonoBehaviour
{
	public bool isLeftSoln;
	public bool restart = false;
    // Start is called before the first frame update
    float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(restart)
    	{
    		time+=Time.deltaTime;
    		if(time>0.75){
    			restart = false;
    			//SceneManager.UnloadSceneAsync("SampleScene");	
    			SceneManager.LoadScene("SampleScene");	
    		}
    		
    	}
    }


    public void clickLeft(){
    	GameObject temp = GameObject.Find("RockManager");
    	temp.transform.GetChild(0).GetComponent<rock>().scroll = true;
    	temp.transform.GetChild(0).GetComponent<rock>().solved = true;
    	temp = GameObject.Find("BG");
    	temp.GetComponent<BGScroll>().scrolling = true;
    	temp.transform.GetChild(0).GetComponent<BGScroll>().scrolling = true;
    	temp = GameObject.Find("Grass");
    	temp.GetComponent<BGScroll>().scrolling = true;
    	temp.transform.GetChild(0).GetComponent<BGScroll>().scrolling = true;
    	temp = GameObject.Find("Canvas");
    	temp.GetComponent<enableButtons>().disable_Buttons();
    	temp = GameObject.Find("Bunny");
    	if(isLeftSoln)
    		temp.GetComponent<bunnyMovement>().jump();
    	else
    		restart = true;

    }

    public void clickRight(){
    	GameObject temp = GameObject.Find("RockManager");
    	temp.transform.GetChild(0).GetComponent<rock>().scroll = true;
    	temp.transform.GetChild(0).GetComponent<rock>().solved = true;
    	temp = GameObject.Find("BG");
    	temp.GetComponent<BGScroll>().scrolling = true;
    	temp.transform.GetChild(0).GetComponent<BGScroll>().scrolling = true;
    	temp = GameObject.Find("Grass");
    	temp.GetComponent<BGScroll>().scrolling = true;
    	temp.transform.GetChild(0).GetComponent<BGScroll>().scrolling = true;
    	temp = GameObject.Find("Canvas");
    	temp.GetComponent<enableButtons>().disable_Buttons();
    	temp = GameObject.Find("Bunny");
    	if(!isLeftSoln)
    		temp.GetComponent<bunnyMovement>().jump();
    	else
    		restart = true;
    }
}
