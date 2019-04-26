using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockManager : MonoBehaviour
{
	public GameObject rock;
	public float spawnInterval = 2f;
	public bool spawnNew = true;
	float timePassed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnNew)
        	if(timePassed < spawnInterval)
        		timePassed+=Time.deltaTime;
        	else{
        		timePassed = 0;
        		spawnNew = false;
        		GameObject rockCopy = Instantiate(rock);//, new Vector3(11.76f,-1.22f,0),Quaternion.identity);
        		rockCopy.transform.parent = transform;
        		GameObject temp = GameObject.Find("solutionManager");
        		temp.GetComponent<solutionManager>().newPair();
        	}
        else if(transform.childCount == 0)
        	spawnNew = true;
    }
}
