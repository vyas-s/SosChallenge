using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BGScroll : MonoBehaviour
{
    Vector2 initialPosition;
    public float scrollSpeed = -5f;
    public bool scrolling = true;
    float pausedTime = 0;
    public float timeStarted = 0;
    // Start is called before the first frame update
    void Start()
    {
    	initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    	if(scrolling){
	    	float updatedPos;
	        updatedPos = Mathf.Repeat((Time.time - pausedTime - timeStarted) * scrollSpeed,20);
	        transform.position = initialPosition + Vector2.right * updatedPos;	
	        GameObject.Find("Canvas").GetComponentInChildren<Text>().text = "DISTANCE: "+Mathf.RoundToInt(Time.time - pausedTime- timeStarted).ToString();
    	}        
    	else
    		pausedTime+=Time.deltaTime;
    }

    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        timeStarted = Time.time;
        pausedTime = 0;
    }
}
