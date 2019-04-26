using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
	public bool scroll = true, solved = false, playedAudio = false;
    public float scrollSpeed = -5f;
    // Start is called before the first frame update
    float timePassed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	timePassed += Time.deltaTime;
    	if(scroll){
    		if(timePassed >= 1 && !playedAudio){
    			GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
    			playedAudio = true;
    			Debug.Log("Played aud");
    		}

    		float updatedPos;
		    updatedPos = Time.deltaTime * scrollSpeed;
		    Vector2 newPos = new Vector2(transform.position.x+updatedPos,transform.position.y);
		    transform.position = newPos;
		    if(transform.position.x <= 0 && !solved){
		    	scroll = false;
		    	GameObject temp = GameObject.Find("BG");
		    	temp.GetComponent<BGScroll>().scrolling = false;
		    	temp.transform.GetChild(0).GetComponent<BGScroll>().scrolling = false;
		    	temp = GameObject.Find("Grass");
		    	temp.GetComponent<BGScroll>().scrolling = false;
		    	temp.transform.GetChild(0).GetComponent<BGScroll>().scrolling = false;
		    	temp = GameObject.Find("Canvas");
		    	temp.GetComponent<enableButtons>().enable_Buttons();
		    }
		    if (transform.position.x < -13){
		    	Destroy(gameObject);
		    }
    	}
        
    }
}
